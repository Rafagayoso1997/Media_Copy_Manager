using MCP.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Forms;
using Button = System.Windows.Controls.Button;
using MessageBox = System.Windows.Forms.MessageBox;
using UserControl = System.Windows.Controls.UserControl;

namespace MCP.gui.Pages.administracion
{
    /// <summary>
    /// Lógica de interacción para PClientes.xaml
    /// </summary>
    public partial class PSeleccionarCliente : UserControl
    {
        private int State { get; set; }
        public object BtnSelect { get; }

        private cliente cliente;
        private usb usb;
        private bool usbToClient;

        public PSeleccionarCliente()
        {
            InitializeComponent();

            refreshGrid();
            usbToClient = false;

            //            AppMAnager.setDefaultForeColor(lNombre.Foreground);

           
            State = AppMAnager.STATE_NULL;
            cliente = null;



        }

        public PSeleccionarCliente(usb usb)
        {
            InitializeComponent();

            refreshGrid();
            usbToClient = true;
           
            this.usb = usb;
            State = AppMAnager.STATE_NULL;
            cliente = null;



        }

        private void refreshGrid()
        {
            List<cliente> clientes = DBManager.ClienteRepo.List.ToList();
            foreach (cliente cliente in clientes)
            {
                Console.WriteLine(cliente.nombre_cliente);
            }
            _dataGrid.ItemsSource = clientes;
        }
        
        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            if (usbToClient)
            {
                cliente = (cliente)_dataGrid.CurrentCell.Item;
                Console.WriteLine(cliente.nombre_cliente);
                DialogResult result = MessageBox.Show("¿El dispositvo pertenece a " + cliente.nombre_cliente + " " + cliente.apellidos_cliente + "?", "Elegir cliente", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.usb.id_cliente = cliente.id_cliente;
                    this.usb.cliente = cliente;
                    DBManager.UsbRepo.Add(usb);
                }
                else
                {
                    this.Visibility = System.Windows.Visibility.Hidden;
                    State = AppMAnager.STATE_INSERT;
                }
            }
        }

        private void SetVisible(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (usbToClient)
            {

                btn.Visibility = Visibility.Visible;
            }
            else
            {
                btn.Visibility = Visibility.Hidden;
            }
        }

       

        
    }
}
