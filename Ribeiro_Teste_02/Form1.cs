using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ribeiro_Teste_02
{
    public partial class FrmClientes : Form
    {
        // string idGrid = ""; Hugo usou esta variavel para receber id eu peguei o txtID.Text
        public FrmClientes()
        {
            InitializeComponent();
            limparTxt();
           
        }
        public void limparTxt()
        {
            txtID.Visible = false;
            lblID.Visible = false;
            txtNome.Text = "";
            txtRua.Text = "";
            txtNome.Focus();
            lstDados.Items.Clear();
        }
        private void FormatarDataGrid()
        {
            dataGridClientes.Columns["id"].HeaderText = "ID";
            dataGridClientes.Columns["nome"].HeaderText = "Nome";
            dataGridClientes.Columns["rua"].HeaderText = "Rua";
            dataGridClientes.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridClientes.Columns["nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridClientes.Columns["rua"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        public void ListarDados()
        {
            //conectar com o servidor
            string enderecoServidor = "SERVER=localhost; DATABASE=teste_02; UID=root; PWD=; PORT=";
            MySqlConnection con = new MySqlConnection(enderecoServidor);
            con.Open();
            string query = "SELECT * FROM clientes order by nome asc";
            MySqlCommand cmd = new MySqlCommand(query, con); //*****
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd; //***********
            DataTable dados = new DataTable(); //tabela vazia
            adaptador.Fill(dados);//preenche a tabela com dados
            con.Close();
            dataGridClientes.DataSource = dados;
            FormatarDataGrid();
        }

        /*------------------------- SELECT MODELO HUGO VASCONCELOS ------------------------------*/
        private void btnHugo(object sender, EventArgs e)
        {
            limparTxt();
            ListarDados();
        }


        /*---------------------- SELECT MDELO JOÃO RIBEIRO -------------------------------------*/
        private void btnSelect_Click(object sender, EventArgs e)
        {
            limparTxt();
            //conectar com o servidor
            string enderecoServidor = "SERVER=localhost; DATABASE=teste_02; UID=root; PWD=; PORT=";
            MySqlConnection con = new MySqlConnection(enderecoServidor);
            con.Open();

            //pegar dados na tabela
            DataTable dados = new DataTable(); //tabela vazia sem colunas ou linhas
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM clientes", con);
            adaptador.Fill(dados); //preenche a tabela com dados
            con.Close(); //ja peguei od dados

            //mostrando no listBox - AULA 79 - https://www.youtube.com/watch?v=XYExbEAYhNc&list=PLXik_5Br-zO-rMqpRy5qPG2SLNimKmVCO&index=79
            foreach (DataRow linha in dados.Rows) //o listbox é uma string
            {
                lstDados.Items.Add(linha["id"].ToString()
                    + " | "
                    + linha["nome"].ToString()
                    + " | "
                    + linha["rua"].ToString());
            }
            
            //mostrando no listView
           dataGridClientes.DataSource = dados; //pega os dados do adaptador
        }

        /*-------------------------------SELECT MODELO  CARLINHOS -------------------------------*/
        private void btnSelectCarlinhos(object sender, EventArgs e)
        {
            limparTxt();
            /*conexão com o servidor*/
            string query = "SELECT * FROM clientes";
            MySqlConnection con = new MySqlConnection();//USAR @ SE TIVER BARRA
            con.ConnectionString = "SERVER=localhost; DATABASE=teste_02; UID=root; PWD=; PORT=";
            con.Open();
                /*
                if(con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Banco aberto");
                }
                else
                {
                    MessageBox.Show("Banco não abriu");
                }
                */

            /*pegar dados*/
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            string campo = "";
            while (dr.Read())
            {
                campo = dr[0].ToString();
                for (int i=1; i < dr.FieldCount; i++){
                    campo = campo + "\t" + dr[i].ToString();
                }
                lstDados.Items.Add(campo);
            }
            con.Close();
        }

        /*----------------------INSERT HUGO VASCONCELOS ---------------------------------*/
        private void btnInsertHugo_Click(object sender, EventArgs e)
        {
            /*abrindo o banco */
            string enderecoServidor = "SERVER=localhost;DATABASE=teste_02;UID=root; PWD=; PORT=;";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = enderecoServidor;
            con.Open();

            /*if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("Banco aberto");
            }
            else
            {
                MessageBox.Show("Banco não abriu");
            }
            */
            /*---------------------------- QUERY DE INSERT ------------------------------*/
            string query = "INSERT INTO clientes(nome, rua) VALUES(@NOME, @RUA)";//@NOME É O txtNome.Text é um parametro e pode ser qualquer coisa
            MySqlCommand cmd = new MySqlCommand(query, con); //inicializa o comando
            cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
            cmd.Parameters.AddWithValue("@RUA", txtRua.Text);
            cmd.ExecuteNonQuery(); //executa o Insert

            con.Close();
            limparTxt();
        }
        /*-----------------INSERT JOÃO RIBEIRO ----------------------------------------------*/
        private void btnInsertJoao_Click(object sender, EventArgs e)
        {
            //ABRE O BANCO
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "SERVER = localhost; DATABASE = teste_02;UID= root; PWD=; PORT= ;";
            con.Open();

            //INSERINDO DADOS
            string query = "INSERT INTO clientes(NOME, RUA) VALUES (@NOME, @RUA)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text); //troquei maisuculas e minusculas para teste
            cmd.Parameters.AddWithValue("@RUA", txtRua.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        /*-------------------------INSERT CARLINHOS ---------------------------------------*/
        private void btnIsertCarlinhos_Click(object sender, EventArgs e)
        {
            //ABRE O BANCO   
            string enderecoBanco = "SERVER = localhost; DATABASE = teste_02; UID= root;PWD= ;PORT =;";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = enderecoBanco;
            con.Open();
            
            //--insert = USA O EXECUTE HEADER
            string query = "INSERT INTO clientes (nome, rua) VALUES(@NOME, @RUA)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
            cmd.Parameters.AddWithValue("@RUA", txtRua.Text);
            cmd.ExecuteReader(CommandBehavior.SingleRow); //comando de comportamento uma linha

            con.Close();
            limparTxt();
        }

        /*------------------------UPDATE DO HUGO VASCONCELOS-----------------------------------*/
        //pega os dados da grid pela "dataGridClientes_CellClick"
        private void btnUpdateHugo_Click(object sender, EventArgs e)
        {
            //abre o banco
            string enderecoBanco = "SERVER=localhost; DATABASE=teste_02; UID= root; PWD=; PORT=";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = enderecoBanco;
            con.Open();

            string query = "UPDATE clientes SET nome = @NOME, rua = @RUA WHERE id = @ID"; //id é o nome do campo que  recebe parametro @ID que recebe de idGrid
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NOME", txtNome.Text); //passa o txt para a query
            cmd.Parameters.AddWithValue("@RUA", txtRua.Text);
            cmd.Parameters.AddWithValue("@ID", txtID.Text);//idGrid passa para o Paramentro @ID que passa para id na clausula where
            cmd.ExecuteNonQuery();

            con.Close();
        }

        /*------------------------UPDATE DO JOÃO RIBEIRO-----------------------------------*/
        //https://www.youtube.com/watch?v=ST7mYXOw-zQ&list=PLXik_5Br-zO-rMqpRy5qPG2SLNimKmVCO&index=82
        private void btnUpdateJoao_Click(object sender, EventArgs e)
        {
            //depende do botão  dataGridClientes_CellClick que gera o ID
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "SERVER=localhost; DATABASE=teste_02; UID=root; PWD=;PORT=";
            con.Open();

            //UPDATE
            string query = "UPDATE clientes SET id = @ID, nome = @NOME, rua = @RUA WHERE id = @ID";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
            cmd.Parameters.AddWithValue("@RUA", txtRua.Text);
            cmd.ExecuteNonQuery();

            con.Close();
             
        }

        /*------------------------UPDATE DO CARLINHOS-----------------------------------*/
        private void btnUpdateCarlinhos_Click(object sender, EventArgs e)
        {
            string enderecoServidor = "SERVER= localhost; DATABASE= teste_02; UID= root;PWD=;PORT=;";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = enderecoServidor;
            con.Open();

            string query = "UPDATE CLIENTES SET ID=@ID, NOME=@NOME, RUA=@RUA WHERE ID=@ID";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
            cmd.Parameters.AddWithValue("@RUA", txtRua.Text);
            cmd.ExecuteReader(CommandBehavior.SingleRow);

            con.Close();
        }

        /*------------------------DELETE DO HUGO VASCONCELOS-----------------------------------*/
        private void btnDeleteHugo_Click(object sender, EventArgs e)
        {
            string enderecoServidor = "SERVER= LOCALHOST; DATABASE= TESTE_02; UID= root; PWD=; PORT=;"; //só a senha precisa ser minuscula
            MySqlConnection con = new MySqlConnection(enderecoServidor);
            con.Open();

            string query = "DELETE FROM clientes WHERE id = @Id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        /*------------------------DELETE DO JOÃO RIBEIRO-----------------------------------*/
        //https://www.youtube.com/watch?v=PyYH7bQ77Qc&list=PLXik_5Br-zO-rMqpRy5qPG2SLNimKmVCO&index=83
        private void btnDeleteJoao_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "SERVER=localhost; DATABASE=teste_02; UID= root ; PWD=; PORT=;";
            con.Open();

            string query = "DELETE FROM clientes WHERE id= @ID";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", txtID.Text); //pega o id na grid
            cmd.ExecuteNonQuery();

            con.Close();
        }

        /*------------------------DELETE DO CARLINHOS-----------------------------------*/
        private void btnDeleteCarlinhos_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection();//USAR @ SE TIVER BARRA
            con.ConnectionString = "SERVER=localhost; DATABASE=teste_02; UID=root; PWD=; PORT=";
            con.Open();

            string query = "DELETE FROM CLIENTES WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID",txtID.Text);
            cmd.ExecuteReader(CommandBehavior.SingleRow);

            con.Close();
        }

        /*------AO CLICAR NA CELULA A LINHA É CAPTURADA--------------------------------- */
        //--foi adicionado o evendo dataGrid em propriedades
        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //idGrid = dataGridClientes.CurrentRow.Cells["id"].Value.ToString(); // Hugo usou, mas eu usei o txtID.Text
            //MessageBox.Show(idGrid); //--para testar
            txtID.Text = dataGridClientes.CurrentRow.Cells["id"].Value.ToString();
            txtNome.Text = dataGridClientes.CurrentRow.Cells["nome"].Value.ToString();
            txtRua.Text = dataGridClientes.CurrentRow.Cells["rua"].Value.ToString();
            
            txtID.Visible = true;
            txtID.Enabled = false;
        }
    } 
}
