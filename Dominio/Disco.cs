using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disco
    {
        public int Id { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [DisplayName("Cantidad de canciones")]
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public Estilo Estilo { get; set; }
        [DisplayName("Edición")]
        public TiposEdicion Edicion { get; set; }
        public Disco(int id,string titulo,DateTime fechaLanzamiento,
            int cantidadCanciones,string url,Estilo estilo,TiposEdicion tipoEdicion)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.FechaLanzamiento = fechaLanzamiento;
            this.CantidadCanciones = cantidadCanciones;
            this.UrlImagenTapa = url;
            this.Estilo = estilo;
            this.Edicion = tipoEdicion;
        }
        public Disco() { }
        
    }
}
