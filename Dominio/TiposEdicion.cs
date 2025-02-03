using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TiposEdicion
    {
        public int Id { get; set; }
        [DisplayName("Tipo de Edición")]
        public string Descripcion { get; set; }
        public TiposEdicion(int id,string descripcion) {
            this.Id = id;
            this.Descripcion = descripcion;
        }
        public TiposEdicion() { }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
