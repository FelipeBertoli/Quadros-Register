using Decor_Register.CConnection;
using Decor_Register.Entidades;
using Decor_Register.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Decor_Register
{
    public partial class FReg : Form
    {
        #region Classes e Construtores
        User user = new User();
        UserModel userModel = new UserModel();
        DataTable dt = new DataTable();
        MySqlCommand sql;
        Connection con = new Connection();
        FList fList = new FList();
        public string _Id, _Imagem, _Produto, _Valor, _Categoria, _Descricao;



        public FReg()
        {
            InitializeComponent();
            Lista();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.SelectedItem = null;

        }
        #endregion
        #region Funções
        public void Preencher()
        {
            comboBox.Text = fList._Categoria;
            txID.Text = fList._Id;
            txProd.Text = fList._Produto;
            txValor.Text = fList._Valor;
            txText.Text = fList._Descricao;
        }
        public void Lista()
        {
            comboBox.DataSource = Box();
            comboBox.DisplayMember = "Categoria";
            comboBox.ValueMember = "Categoria";
        }
        #endregion
        #region Categoria
        public List<Cat> Box()
        {
            List<Cat> lista = new List<Cat>()
             {
                new Cat() { Categoria = "A"},
                new Cat() { Categoria = "B"},
                new Cat() { Categoria = "C"}
            };
            return lista;
        }
        public class Cat
        {
            public string Categoria { get; set; }
        }


        #endregion
        #region Botões
        private void btAbrir_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg) |*.jpg| PNG files (*.png) |*.png| Todos os Arquivos(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {


                    imageLocation = dialog.FileName;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.ImageLocation = imageLocation;
                    string path = imageLocation;
                    byte[] imageData = File.ReadAllBytes(@path);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errado");
            }
        }
        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            byte[] imageData = File.ReadAllBytes(pictureBox.ImageLocation);
            user.Imagem = imageData;
            user.Categoria = comboBox.Text;
            user.Produto = txProd.Text;
            user.Valor = txValor.Text;
            user.Descricao = txText.Text;
            userModel.Save(user);

            MessageBox.Show("Salvo com sucesso", "System message", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            user.ID = txID.Text;
            userModel.Delete(user);

            MessageBox.Show("Excluído com sucesso", "System message",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btEditar_Click(object sender, EventArgs e)
        {
            user.ID = txID.Text;
            user.Categoria = comboBox.Text;
            user.Produto = txProd.Text;
            user.Valor = txValor.Text;
            user.Descricao = txText.Text;
            userModel.Edit(user);

            MessageBox.Show("Editado com sucesso", "System message", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void btLista_Click(object sender, EventArgs e)
        {
            fList.ShowDialog();
            Preencher();
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
        }
        #endregion
    }
}
