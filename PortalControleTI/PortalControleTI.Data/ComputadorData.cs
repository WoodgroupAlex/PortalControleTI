using PortalControleTI.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PortalControleTI.Data
{
    public class ComputadorData
    {
        public static List<Computador> GetComputadores()
        {
            string SqlQuery = "Select * " +
                              "From Computadores " +
                              "Order By DataAtualizacao";

            SqlCommand ComandoSQL = new SqlCommand(SqlQuery, ConexaoBanco.ConexaoSQL());
            SqlDataReader Leitor = ComandoSQL.ExecuteReader();

            List<Computador> Computador = new List<Computador>();

            foreach (var leitor in Leitor)
            {
                Computador _Computador = new Computador
                {
                    CT = Leitor["CT"].ToString(),
                    NFe = Leitor["NFe"].ToString(),
                    Data = DateTime.Parse(Leitor["Data"].ToString()),
                    Fabricante = Leitor["Fabricante"].ToString(),
                    Modelo = Leitor["Modelo"].ToString(),
                    Serial = Leitor["Serial"].ToString(),
                    Usuario = Leitor["Usuario"].ToString(),
                    ComputerName = Leitor["ComputerName"].ToString(),
                    Status = (Status)Enum.Parse(typeof(Status), Leitor["Status"].ToString()),
                    Matricula = Leitor["Matricula"].ToString(),
                    Tipo = (Tipo)Enum.Parse(typeof(Tipo), Leitor["Tipo"].ToString()),
                    DataAtualizacao = DateTime.Parse(Leitor["DataAtualizacao"].ToString()),
                    Obs = Leitor["Obs"].ToString(),
                    Local = Leitor["Local"].ToString()
                };

                Computador.Add(_Computador);
            }

            return Computador;
        }

        public static void Incluir(Computador computador)
        {
            StringBuilder SqlInsert = new StringBuilder();

            SqlInsert.Append($"Insert Into Computadores " +
                             $"Values (@CT, @NFe, @Data, @Fabricante, @Modelo, @Serial, @Usuario, @ComputerName, @Status, @Matricula, @Tipo, @DataAtualizacao, @Obs, @Local)");

            SqlCommand ComandoSQL = new SqlCommand(SqlInsert.ToString(), ConexaoBanco.ConexaoSQL());
            ComandoSQL.Parameters.AddWithValue("@CT", ((object)computador.CT) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@NFe", ((object)computador.NFe) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@Data", computador.Data);
            ComandoSQL.Parameters.AddWithValue("@Fabricante", ((object)computador.Fabricante) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@Modelo", ((object)computador.Modelo) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@Serial", computador.Serial);
            ComandoSQL.Parameters.AddWithValue("@Usuario", ((object)computador.Usuario) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@ComputerName", computador.ComputerName);
            ComandoSQL.Parameters.AddWithValue("@Status", computador.Status);
            ComandoSQL.Parameters.AddWithValue("@Matricula", ((object)computador.Matricula) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@Tipo", computador.Tipo);
            ComandoSQL.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now.Date);
            ComandoSQL.Parameters.AddWithValue("@Obs", ((object)computador.Obs) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@Local", ((object)computador.Local) ?? DBNull.Value);

            ComandoSQL.ExecuteNonQuery();

            ConexaoBanco.ConexaoSQL().Close();
        }

        public static void Atualizar(Computador computador)
        {
            StringBuilder SqlUpdate = new StringBuilder();

            SqlUpdate.Append("Update Computadores ");
            SqlUpdate.Append($"Set CT = @CT, NFe = @NFe, Data = @Data" +
                             $", Fabricante = @Fabricante, Modelo = @Modelo, Usuario = @Usuario, ComputerName = @ComputerName, Status = @Status " +
                             $", Matricula = @Matricula, Tipo = @Tipo, DataAtualizacao = @DataAtualizacao, Obs = @Obs, Local = @Local " +
                             $"Where Serial = @Serial");

            SqlCommand ComandoSQL = new SqlCommand(SqlUpdate.ToString(), ConexaoBanco.ConexaoSQL());
            ComandoSQL.Parameters.AddWithValue("@CT", ((object)computador.CT) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@NFe", ((object)computador.NFe) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@Data", computador.Data);
            ComandoSQL.Parameters.AddWithValue("@Fabricante", ((object)computador.Fabricante) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@Modelo", ((object)computador.Modelo) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@Serial", computador.Serial);
            ComandoSQL.Parameters.AddWithValue("@Usuario", ((object)computador.Usuario) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@ComputerName", computador.ComputerName);
            ComandoSQL.Parameters.AddWithValue("@Status", computador.Status);
            ComandoSQL.Parameters.AddWithValue("@Matricula", ((object)computador.Matricula) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@Tipo", computador.Tipo);
            ComandoSQL.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now.Date);
            ComandoSQL.Parameters.AddWithValue("@Obs", ((object)computador.Obs) ?? DBNull.Value);
            ComandoSQL.Parameters.AddWithValue("@Local", ((object)computador.Local) ?? DBNull.Value);

            ComandoSQL.ExecuteNonQuery();

            ConexaoBanco.ConexaoSQL().Close();
        }
    }
}
