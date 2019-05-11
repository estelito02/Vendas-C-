using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Importa Biblioteca 
using System.Data;
using MySql.Data.MySqlClient;

namespace Vendas_turma
{
    class ConexaoBD
    {
        MySqlConnection con;

        //String de Conexão
        public void ConectarBD()
        {
            try
            {
                con = new MySqlConnection("Persist Security info= false;server = localhost;database=supermercado;user=root;pwd=;");
                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }


        //comandos de Insert, Delete, Update
        public int executarcomandos(string sql)
        {
            try
            {
                ConectarBD();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }

        }

        //executar consulta
        public DataTable executarconsulta(string sql)
        {
            try
            {
                ConectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }




    }
}
