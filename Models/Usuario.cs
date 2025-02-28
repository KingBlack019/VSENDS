using System.ComponentModel.DataAnnotations;

namespace VSENDS.Models
{
	public class Usuario
	{

		public string Id {  get; set; }
		
		[Required, StringLength(20)]
		public string Nombre { get; set; }

		[Required, StringLength(20)]
		public string Apellidos { get; set; }

		[Required, StringLength(50)]
		public string Email { get; set; }

		[Required]
		public int NumTelefono {  get; set; }
		
		[Required]
		public Rol RolUsuario { get; set; }
	}
}
