using System.Data.SqlClient;

namespace PortalControleTI.Data
{
    class ConexaoBanco
    {
        public static SqlConnection ConexaoSQL()
        {
            SqlConnection SqlConexao = new SqlConnection(@"Data Source = RIO01T-SQL01; Initial Catalog = ControleTI; User Id = rm;Password = rm;");
            SqlConexao.Open();

            return SqlConexao;
        }
    }
}
