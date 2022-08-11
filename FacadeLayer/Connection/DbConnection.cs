using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FacadeLayer.Connection
{
    internal class DbConnection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-07T8MF2\MSSQLSERVER01;Initial Catalog=DbAkademiFilmDizi;integrated Security=True");
    }
}
