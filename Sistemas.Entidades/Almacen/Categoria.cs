using System;
using System.Collections.Generic;
using System.Text;

namespace Sistemas.Entidades.Almacen
{
    public class Categoria
    {
        public int idcategoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool condicion { get; set; }
    }
}
