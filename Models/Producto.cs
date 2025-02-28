using System.ComponentModel.DataAnnotations;

namespace VSENDS.Models
{
	public class Producto
	{
		public string Id { get; set; }

		[Required, StringLength(50)]
		public string Nombre { get; set; }

		[Required]
		public Categoria Categoria { get; set; }

		[Required, Range(0.01, 10000)]
		public decimal Precio { get; set; }

		public string ImagenUrl { get; set; }

		public Producto(string id, string nombre, Categoria categoria, decimal precio, string imagenUrl)
		{
			Id = id;
			Nombre = nombre;
			Categoria = categoria;
			Precio = precio;
			ImagenUrl = imagenUrl;
		}
	}
}
