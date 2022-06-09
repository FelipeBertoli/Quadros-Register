
namespace Decor_Register
{
    partial class FReg
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FReg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAbrir = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btLista = new System.Windows.Forms.Button();
            this.txID = new System.Windows.Forms.TextBox();
            this.txText = new System.Windows.Forms.RichTextBox();
            this.txProd = new System.Windows.Forms.TextBox();
            this.txValor = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(138, 25);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(183, 21);
            this.comboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIA:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.btAbrir);
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txID);
            this.groupBox2.Controls.Add(this.txText);
            this.groupBox2.Controls.Add(this.txProd);
            this.groupBox2.Controls.Add(this.txValor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(30, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 412);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btAbrir
            // 
            this.btAbrir.BackColor = System.Drawing.Color.DarkViolet;
            this.btAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAbrir.Location = new System.Drawing.Point(212, 43);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 32);
            this.btAbrir.TabIndex = 14;
            this.btAbrir.Text = "ABRIR";
            this.btAbrir.UseVisualStyleBackColor = false;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(94, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 92);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "IMAGEM";
            // 
            // btLista
            // 
            this.btLista.BackColor = System.Drawing.Color.Indigo;
            this.btLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLista.Location = new System.Drawing.Point(103, 47);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(94, 39);
            this.btLista.TabIndex = 11;
            this.btLista.Text = "LISTA";
            this.btLista.UseVisualStyleBackColor = false;
            this.btLista.Click += new System.EventHandler(this.btLista_Click);
            // 
            // txID
            // 
            this.txID.Enabled = false;
            this.txID.Location = new System.Drawing.Point(249, 160);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(27, 20);
            this.txID.TabIndex = 10;
            // 
            // txText
            // 
            this.txText.BackColor = System.Drawing.SystemColors.Control;
            this.txText.Location = new System.Drawing.Point(93, 188);
            this.txText.Name = "txText";
            this.txText.Size = new System.Drawing.Size(213, 123);
            this.txText.TabIndex = 9;
            this.txText.Text = "";
            // 
            // txProd
            // 
            this.txProd.BackColor = System.Drawing.SystemColors.Control;
            this.txProd.Location = new System.Drawing.Point(94, 133);
            this.txProd.Name = "txProd";
            this.txProd.Size = new System.Drawing.Size(212, 20);
            this.txProd.TabIndex = 7;
            // 
            // txValor
            // 
            this.txValor.BackColor = System.Drawing.SystemColors.Control;
            this.txValor.Location = new System.Drawing.Point(94, 160);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(100, 20);
            this.txValor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "DESCRIÇÃO ";
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DarkViolet;
            this.btExcluir.Enabled = false;
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btExcluir.Location = new System.Drawing.Point(3, 47);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(94, 39);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.DarkViolet;
            this.btEditar.Enabled = false;
            this.btEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEditar.Location = new System.Drawing.Point(103, 3);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(94, 38);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.BackColor = System.Drawing.Color.DarkViolet;
            this.bt_Cadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Cadastrar.Location = new System.Drawing.Point(3, 3);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(94, 38);
            this.bt_Cadastrar.TabIndex = 2;
            this.bt_Cadastrar.Text = "CADASTRAR";
            this.bt_Cadastrar.UseVisualStyleBackColor = false;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "PREÇO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PRODUTO";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bt_Cadastrar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btEditar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btExcluir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btLista, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(76, 317);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 89);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // FReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(436, 538);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FReg";
            this.Text = "Quadros Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txText;
        private System.Windows.Forms.TextBox txProd;
        private System.Windows.Forms.MaskedTextBox txValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.Button btLista;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

