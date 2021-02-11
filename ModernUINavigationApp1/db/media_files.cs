//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MCP.db
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public partial class media_files
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public media_files()
        {
            this.media_generos = new HashSet<media_generos>();
            this.media_paises = new HashSet<media_paises>();
        }

        public int id { get; set; }
        public int categoria_id { get; set; }
        public int punto_copia_id { get; set; }
        public Nullable<int> parent_id { get; set; }
        public string file_url { get; set; }
        public string str_file { get; set; }
        public string fichero_portada { get; set; }
        public string fichero_trailer { get; set; }
        public string titulo { get; set; }
        public Nullable<int> anno { get; set; }
        public string director { get; set; }
        public string reparto { get; set; }
        public string sinopsis { get; set; }
        public Nullable<int> duracion { get; set; }
        public string productora { get; set; }
        public string premios { get; set; }
        public bool is_folder { get; set; }

        public virtual categoria categoria { get; set; }
        public virtual copia_puntos copia_puntos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<media_generos> media_generos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<media_paises> media_paises { get; set; }


        public bool FileExists()
        {
            if (is_folder)
                return Directory.Exists(this.file_url);
            else
                return File.Exists(this.file_url);
        }
    }
}
