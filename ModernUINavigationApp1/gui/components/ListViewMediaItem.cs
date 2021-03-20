using MCP.db;
using MCP.gui.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MCP.gui.components
{
    public class ListViewMediaItem : ContentControl
    {
        private media_files mf= null;
        private int mediaId;
        private int categoriaId;
        private bool is_folder;
        private bool file_exists;

        //public bool StandBy { get; set; }

        public ListViewMediaItem(media_files mf)
        {
            this.mf = mf;
            this.mediaId = mf.id;
            this.categoriaId = mf.categoria_id;
            this.is_folder = mf.is_folder;

            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Horizontal;

            Label l = new Label();
            l.Content = mf.titulo+"  |  "+mf.file_url;
            l.Margin = new Thickness(5);

            Image img = new Image();
            img.Height = 22;
            img.Width = 18;
            BitmapImage bmi;

            if (mf.is_folder)
                bmi = new BitmapImage(new Uri("pack://application:,,,/Resources/folder.ico"));
            else
                bmi = new BitmapImage(new Uri("pack://application:,,,/Resources/cinema.png"));

            img.Source = bmi;

            sp.Children.Add(img);
            sp.Children.Add(l);
            this.Content = sp;

            file_exists = mf.FileExists();
            BrushConverter bc = new BrushConverter();
            if (!file_exists)
            {
                l.Foreground = (Brush)bc.ConvertFrom(AppMAnager.COLOR_ERROR_FOREGROUND);
            }
            else
                l.Foreground = AppMAnager.DefaultLabelForeColor();

            this.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(Item_MouseDoubleClick);

            AddContextMenu();
           // this.StandBy = false;
        }

        //Añadir click derecho
        private void AddContextMenu()
        {
            if (!this.mf.is_folder)
            {
                ContextMenu menu = new ContextMenu();
                MenuItem men = new MenuItem();
                men.Header = "Eliminar";
                men.Click += Delete_Media;
                menu.Items.Add(men);

                /* menu.Items.Add("Copiar", new RoutedEventHandler(Copy_Media));
                 menu.Items.Add("Abrir en el explorador", new RoutedEventHandler(Open_Media));
                 menu.Items.Add("Enviar", new RoutedEventHandler(Send_Media));
                 menu.Items.Add("Eliminar", new RoutedEventHandler(Delete_Media));*/
                this.ContextMenu = menu;
            }
            
        }

        private void Copy_Media(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            MessageBox.Show(item.Header.ToString() + " " + mf.titulo.ToString());

        }

        private void Open_Media(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            MessageBox.Show(item.Header.ToString() + " " + mf.titulo.ToString());

        }

        private void Send_Media(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            MessageBox.Show(item.Header.ToString() + " " + mf.titulo.ToString());

        }

        private void Delete_Media(object sender, EventArgs e)
        {
            if (mf != null)
            {
                MessageBoxResult res = MessageBox.Show("¿Confirma que desea eliminar el archivo del catálogo?", "Información", MessageBoxButton.YesNo);
                if (res == MessageBoxResult.Yes)
                {
                    DBManager.MediaFilesRepo.DeleteEntity(mf);
                    mf = null;

                   
                    AppMAnager.GlobalContentChanged(true);
                }
            }
           

        }

        private void Item_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (is_folder)
            {
                PHome._PHome.ClearFilter();

                List<media_files> mfList = DBManager.MediaFilesRepo.FindByCategoria(categoriaId, mediaId, false);
                HomeCatalogManager.ShowItemContent(mfList);
                PHome._PHome.SelectTreeViewFolder(mediaId);
            }
            else
            if(file_exists)
            {
                media_files mf = DBManager.MediaFilesRepo.FindById(mediaId);
                if(mf != null)
                {
                    Process.Start(@mf.file_url);
                    //File.e mf.file_url;
                }
            }
        }

        public int MediaId()
        {
            return mediaId;
        }

        public bool FileExists()
        {
            return file_exists;
        }

        
    }
}
