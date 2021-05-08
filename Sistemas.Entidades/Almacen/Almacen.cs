using System.ComponentModel.DataAnnotations;

namespace Sistemas.Entidades.Almacen
{
    public class Almacen
    {
        public int idcategoria { get; set; }
        //Data Annotation para requerir u Obligatorio
        [Required]
        //Maximo de caracteres requeridos
        [StringLength(50, MinimumLength =3, ErrorMessage ="El nombre no debe tener más de 50 carácteres, por favor validar")]

        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }

    }
}
