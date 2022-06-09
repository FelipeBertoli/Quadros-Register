using Decor_Register.Entidades;
using Decor_Register.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Decor_Register
{
    public partial class FList : Form
    {
        DataTable dt = new DataTable();
        User user = new User();
        UserModel userModel = new UserModel();
        public string _Id, _Imagem, _Produto, _Valor, _Categoria, _Descricao;


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                btProcurar.Enabled = false;
            }
            else
            {
                do
                {
                    btProcurar.Enabled = true;
                }
                while (string.IsNullOrEmpty(textBox.Text));
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _Id = dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            _Imagem = dataGridView.Rows[e.RowIndex].Cells["Imagem"].Value.ToString();
            _Categoria = dataGridView.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            _Produto = dataGridView.Rows[e.RowIndex].Cells["Produto"].Value.ToString();
            _Valor = dataGridView.Rows[e.RowIndex].Cells["Valor"].Value.ToString();
            _Descricao = dataGridView.Rows[e.RowIndex].Cells["Texto"].Value.ToString();

            this.Close();
        }

        public FList()
        {
            InitializeComponent();
            ProdList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProdList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.RowTemplate.Height = 100;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }


        public void ProdList()
        {
            dt = userModel.ProdList();
            dataGridView.DataSource = dt;
        }
    }
}
