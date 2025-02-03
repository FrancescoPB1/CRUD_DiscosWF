using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Estilo
    {
        public int Id { get; set; }
        [DisplayName("Tipos de Estilos")]
        public string Descripcion { get; set; }
        public Estilo(int id,string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }
        public Estilo() { }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
