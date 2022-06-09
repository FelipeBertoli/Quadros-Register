using System;
using System.Data;
using Decor_Register.CConnection;
using Decor_Register.Entidades;
using MySqlConnector;

namespace Decor_Register.Controller
{
    class UserController
    {
        MySqlCommand sql;
        Connection con = new Connection();
        public DataTable ProdList()
        {
            try
            {
                con.AbrirConnection();
                sql = new MySqlCommand("SELECT * FROM `registro`;", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Save(User user)
        {
            try
            {
                con.AbrirConnection();
                sql = new MySqlCommand("INSERT INTO registro (Imagem, Categoria, Produto, Valor, Texto) " +
                    "values (@Imagem, @Categoria, @Produto, @Valor, @Descricao)", con.con);


                sql.Parameters.AddWithValue("@Imagem", MySqlDbType.Blob).Value = user.Imagem;
                sql.Parameters.AddWithValue("@Categoria", user.Categoria);
                sql.Parameters.AddWithValue("@Produto", user.Produto);
                sql.Parameters.AddWithValue("@Valor", user.Valor);
                sql.Parameters.AddWithValue("@Descricao", user.Descricao);
                sql.ExecuteNonQuery();
                con.FecharConnection();
                
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Delete(User user)
        {
            try
            {
                con.AbrirConnection();
                sql = new MySqlCommand("DELETE FROM registro where ID = " + user.ID, con.con);
                sql.ExecuteNonQuery();
                con.FecharConnection();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(User user)
        {
            try
            {
                con.AbrirConnection();
                sql = new MySqlCommand("UPDATE registro SET Categoria = @Categoria, Produto = @Produto, " +
                                       "Valor = @Valor, Texto = @Descricao where ID = " + user.ID, con.con);
                sql.Parameters.AddWithValue("@Categoria", user.Categoria);
                sql.Parameters.AddWithValue("@Produto", user.Produto);
                sql.Parameters.AddWithValue("@Valor", user.Valor);
                sql.Parameters.AddWithValue("@Descricao", user.Descricao);
                sql.ExecuteNonQuery();
                con.FecharConnection();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Filtrar(int ID)
        {
            try
            {
               con.AbrirConnection();
                sql = new MySqlCommand("SELECT * FROM registro where * like " + ID, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
               da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
               throw;
            }
        }
    }
}
