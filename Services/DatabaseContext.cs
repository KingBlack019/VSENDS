using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace VSENDS.Services
{
	public class DatabaseContext
	{
		private readonly string _connectionString;

		public DatabaseContext(IConfiguration configuration)
		{
			_connectionString = configuration.GetConnectionString("MySQLConnection");
		}

		public MySqlConnection GetConnection()
		{
			return new MySqlConnection(_connectionString);
		}

	}
}
