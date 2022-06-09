using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Decor_Register.CConnection
{
    class Connection
    {
        string connection = "SERVER=localhost; DATABASE= quadros; UID= root; PWD= ";
        public MySqlConnection con = null;
        public void AbrirConnection()
        {
            try
            {
                con = new MySqlConnection(connection);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar" + ex.Message);
            }
        }
        public void FecharConnection()
        {
            try
            {
                con = new MySqlConnection(connection);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar conexão" + ex.Message);
            }
        }

    }
}
