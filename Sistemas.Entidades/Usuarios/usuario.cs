using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistemas.Entidades.Usuarios
{
    public class usuario
    {
        public int idUsuario { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El nombre de usuario debe tener un máximo de 100 o al menos debe tener 10 carácteres.")]
        public string nombre { get; set; }
        public int tipo_documento { get; set; }
        public int num_documento { get; set; }
        [Required]
        [StringLength(70, MinimumLength =25, ErrorMessage ="La dirección el máximo de carácteres debe ser de 70 o al menos 25.")]
        public string direccion { get; set; }
        [Required]
        [StringLength(11, ErrorMessage ="Recuerde el número de teléfono debe contener al menos 11 digitos")]
        public string telefono { get; set; }
        //actividad en blacckboard -> 
        public string email { get; set; }
        public string password_hash { get; set; }
        public string password_salt { get; set; }
        public bool condicion { get; set; }
    }
}
