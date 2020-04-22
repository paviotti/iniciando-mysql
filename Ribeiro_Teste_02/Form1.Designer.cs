namespace Ribeiro_Teste_02
{
    partial class FrmClientes
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsertHugo = new System.Windows.Forms.Button();
            this.btnUpdateHugo = new System.Windows.Forms.Button();
            this.btnDeleteHugo = new System.Windows.Forms.Button();
            this.lstDados = new System.Windows.Forms.ListBox();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.btnSelectHugo = new System.Windows.Forms.Button();
            this.btnCarlinhos = new System.Windows.Forms.Button();
            this.btnInsertJoao = new System.Windows.Forms.Button();
            this.btnIsertCarlinhos = new System.Windows.Forms.Button();
            this.btnUpdateJoao = new System.Windows.Forms.Button();
            this.btnUpdateCarlinhos = new System.Windows.Forms.Button();
            this.btnDeleteJoao = new System.Windows.Forms.Button();
            this.btnDeleteCarlinhos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(66, 55);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 18);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Id:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(144, 51);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 24);
            this.txtID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(144, 94);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(378, 24);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rua:";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(144, 136);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(378, 24);
            this.txtRua.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(661, 25);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(112, 48);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select\r\nJoão\r\n";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsertHugo
            // 
            this.btnInsertHugo.Location = new System.Drawing.Point(541, 86);
            this.btnInsertHugo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertHugo.Name = "btnInsertHugo";
            this.btnInsertHugo.Size = new System.Drawing.Size(112, 48);
            this.btnInsertHugo.TabIndex = 6;
            this.btnInsertHugo.Text = "Insert\r\nHugo";
            this.btnInsertHugo.UseVisualStyleBackColor = true;
            this.btnInsertHugo.Click += new System.EventHandler(this.btnInsertHugo_Click);
            // 
            // btnUpdateHugo
            // 
            this.btnUpdateHugo.Location = new System.Drawing.Point(541, 144);
            this.btnUpdateHugo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateHugo.Name = "btnUpdateHugo";
            this.btnUpdateHugo.Size = new System.Drawing.Size(112, 44);
            this.btnUpdateHugo.TabIndex = 9;
            this.btnUpdateHugo.Text = "Update\r\nHugo";
            this.btnUpdateHugo.UseVisualStyleBackColor = true;
            this.btnUpdateHugo.Click += new System.EventHandler(this.btnUpdateHugo_Click);
            // 
            // btnDeleteHugo
            // 
            this.btnDeleteHugo.Location = new System.Drawing.Point(541, 200);
            this.btnDeleteHugo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteHugo.Name = "btnDeleteHugo";
            this.btnDeleteHugo.Size = new System.Drawing.Size(112, 45);
            this.btnDeleteHugo.TabIndex = 12;
            this.btnDeleteHugo.Text = "Delete\r\nHugo";
            this.btnDeleteHugo.UseVisualStyleBackColor = true;
            this.btnDeleteHugo.Click += new System.EventHandler(this.btnDeleteHugo_Click);
            // 
            // lstDados
            // 
            this.lstDados.FormattingEnabled = true;
            this.lstDados.ItemHeight = 18;
            this.lstDados.Location = new System.Drawing.Point(560, 296);
            this.lstDados.Name = "lstDados";
            this.lstDados.Size = new System.Drawing.Size(301, 238);
            this.lstDados.TabIndex = 16;
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(52, 296);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.Size = new System.Drawing.Size(470, 238);
            this.dataGridClientes.TabIndex = 15;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            // 
            // btnSelectHugo
            // 
            this.btnSelectHugo.Location = new System.Drawing.Point(541, 25);
            this.btnSelectHugo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectHugo.Name = "btnSelectHugo";
            this.btnSelectHugo.Size = new System.Drawing.Size(112, 48);
            this.btnSelectHugo.TabIndex = 3;
            this.btnSelectHugo.Text = "Select\r\nHugo";
            this.btnSelectHugo.UseVisualStyleBackColor = true;
            this.btnSelectHugo.Click += new System.EventHandler(this.btnHugo);
            // 
            // btnCarlinhos
            // 
            this.btnCarlinhos.Location = new System.Drawing.Point(781, 25);
            this.btnCarlinhos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarlinhos.Name = "btnCarlinhos";
            this.btnCarlinhos.Size = new System.Drawing.Size(112, 48);
            this.btnCarlinhos.TabIndex = 5;
            this.btnCarlinhos.Text = "Select\r\nCarlinhos";
            this.btnCarlinhos.UseVisualStyleBackColor = true;
            this.btnCarlinhos.Click += new System.EventHandler(this.btnSelectCarlinhos);
            // 
            // btnInsertJoao
            // 
            this.btnInsertJoao.Location = new System.Drawing.Point(661, 86);
            this.btnInsertJoao.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertJoao.Name = "btnInsertJoao";
            this.btnInsertJoao.Size = new System.Drawing.Size(112, 48);
            this.btnInsertJoao.TabIndex = 7;
            this.btnInsertJoao.Text = "Insert\r\nJoão\r\n";
            this.btnInsertJoao.UseVisualStyleBackColor = true;
            this.btnInsertJoao.Click += new System.EventHandler(this.btnInsertJoao_Click);
            // 
            // btnIsertCarlinhos
            // 
            this.btnIsertCarlinhos.Location = new System.Drawing.Point(781, 86);
            this.btnIsertCarlinhos.Margin = new System.Windows.Forms.Padding(4);
            this.btnIsertCarlinhos.Name = "btnIsertCarlinhos";
            this.btnIsertCarlinhos.Size = new System.Drawing.Size(112, 48);
            this.btnIsertCarlinhos.TabIndex = 8;
            this.btnIsertCarlinhos.Text = "Insert Carlinhos";
            this.btnIsertCarlinhos.UseVisualStyleBackColor = true;
            this.btnIsertCarlinhos.Click += new System.EventHandler(this.btnIsertCarlinhos_Click);
            // 
            // btnUpdateJoao
            // 
            this.btnUpdateJoao.Location = new System.Drawing.Point(661, 144);
            this.btnUpdateJoao.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateJoao.Name = "btnUpdateJoao";
            this.btnUpdateJoao.Size = new System.Drawing.Size(112, 44);
            this.btnUpdateJoao.TabIndex = 10;
            this.btnUpdateJoao.Text = "Update\r\nJoão";
            this.btnUpdateJoao.UseVisualStyleBackColor = true;
            this.btnUpdateJoao.Click += new System.EventHandler(this.btnUpdateJoao_Click);
            // 
            // btnUpdateCarlinhos
            // 
            this.btnUpdateCarlinhos.Location = new System.Drawing.Point(781, 142);
            this.btnUpdateCarlinhos.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCarlinhos.Name = "btnUpdateCarlinhos";
            this.btnUpdateCarlinhos.Size = new System.Drawing.Size(112, 44);
            this.btnUpdateCarlinhos.TabIndex = 11;
            this.btnUpdateCarlinhos.Text = "Update\r\nCarlinhos";
            this.btnUpdateCarlinhos.UseVisualStyleBackColor = true;
            this.btnUpdateCarlinhos.Click += new System.EventHandler(this.btnUpdateCarlinhos_Click);
            // 
            // btnDeleteJoao
            // 
            this.btnDeleteJoao.Location = new System.Drawing.Point(661, 199);
            this.btnDeleteJoao.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteJoao.Name = "btnDeleteJoao";
            this.btnDeleteJoao.Size = new System.Drawing.Size(112, 45);
            this.btnDeleteJoao.TabIndex = 13;
            this.btnDeleteJoao.Text = "Delete\r\nJoão";
            this.btnDeleteJoao.UseVisualStyleBackColor = true;
            this.btnDeleteJoao.Click += new System.EventHandler(this.btnDeleteJoao_Click);
            // 
            // btnDeleteCarlinhos
            // 
            this.btnDeleteCarlinhos.Location = new System.Drawing.Point(781, 198);
            this.btnDeleteCarlinhos.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCarlinhos.Name = "btnDeleteCarlinhos";
            this.btnDeleteCarlinhos.Size = new System.Drawing.Size(112, 45);
            this.btnDeleteCarlinhos.TabIndex = 14;
            this.btnDeleteCarlinhos.Text = "Delete\r\nCarlinhos";
            this.btnDeleteCarlinhos.UseVisualStyleBackColor = true;
            this.btnDeleteCarlinhos.Click += new System.EventHandler(this.btnDeleteCarlinhos_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 623);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.lstDados);
            this.Controls.Add(this.btnDeleteCarlinhos);
            this.Controls.Add(this.btnDeleteJoao);
            this.Controls.Add(this.btnDeleteHugo);
            this.Controls.Add(this.btnUpdateCarlinhos);
            this.Controls.Add(this.btnUpdateJoao);
            this.Controls.Add(this.btnUpdateHugo);
            this.Controls.Add(this.btnIsertCarlinhos);
            this.Controls.Add(this.btnInsertJoao);
            this.Controls.Add(this.btnInsertHugo);
            this.Controls.Add(this.btnSelectHugo);
            this.Controls.Add(this.btnCarlinhos);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClientes";
            this.Text = "clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsertHugo;
        private System.Windows.Forms.Button btnUpdateHugo;
        private System.Windows.Forms.Button btnDeleteHugo;
        private System.Windows.Forms.ListBox lstDados;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Button btnSelectHugo;
        private System.Windows.Forms.Button btnCarlinhos;
        private System.Windows.Forms.Button btnInsertJoao;
        private System.Windows.Forms.Button btnIsertCarlinhos;
        private System.Windows.Forms.Button btnUpdateJoao;
        private System.Windows.Forms.Button btnUpdateCarlinhos;
        private System.Windows.Forms.Button btnDeleteJoao;
        private System.Windows.Forms.Button btnDeleteCarlinhos;
    }
}

