using System;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using SqlServerTypes;

namespace DapperTestApp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

			var connection = new SqlConnection("Data Source=.;Initial Catalog=TempDb;User Id=sa;Password=123");
			var val = connection.Query<Microsoft.SqlServer.Types.SqlHierarchyId>("select @Path", new {Path = Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/1/2/3/")}).Single();
		}
	}
}