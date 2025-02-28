using VSENDS.Models;

namespace VSENDS.Services
{
	public class ProductoService
	{
		private readonly DatabaseContext _dbContext;

		public static List<Producto> ObtenerProductos()
		{
			var products = new List<Producto>();

			products.Add( new Producto("ABC", "Ordenador Gaming 1", Categoria.HARDWARE, 1000.00m, "/Images/pc1.jpeg"));
			products.Add(new Producto("AAA", "Sonic Colors", Categoria.SOFTWARE, 10.00m, "/Images/sonic_colors.webp"));
			products.Add(new Producto("ABB", "Windows 10 home", Categoria.LICENCIAS, 100.00m, "/Images/w10.jpg"));
			products.Add(new Producto("BAA", "Cascos Razer", Categoria.PERIFERICOS, 100.00m, "/Images/cascosRazer.jpg"));
			products.Add(new Producto("BCA", "Ordenador Gaming 2", Categoria.HARDWARE, 1200.00m, "/Images/pc2.jpeg"));
			products.Add(new Producto("BCB", "Rayman Legends", Categoria.SOFTWARE, 12.00m, "/Images/RaymanLegends.webp"));

			products.Add(new Producto("ABB", "Windows 10 home", Categoria.LICENCIAS, 100.00m, "/Images/w10.jpg"));
			products.Add(new Producto("BAA", "Cascos Razer", Categoria.PERIFERICOS, 100.00m, "/Images/cascosRazer.jpg"));
			products.Add(new Producto("ABC", "Ordenador Gaming 1", Categoria.HARDWARE, 1000.00m, "/Images/pc1.jpeg"));
			products.Add(new Producto("AAA", "Sonic Colors", Categoria.SOFTWARE, 10.00m, "/Images/sonic_colors.webp"));
			products.Add(new Producto("BCA", "Ordenador Gaming 2", Categoria.HARDWARE, 1200.00m, "/Images/pc2.jpeg"));
			products.Add(new Producto("BCB", "Rayman Legends", Categoria.SOFTWARE, 12.00m, "/Images/RaymanLegends.webp"));

			return products;
		}
	}
}