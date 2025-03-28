using MySql.Data.MySqlClient;
using System.Data;

namespace Aula_CRUD_M
{
    public partial class Form1 : Form
    {
        public MySqlConnection conexao;
        string fotoEndereco = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (btNovo.Text == "Novo")
            {
                btSalvar.Enabled = true;
                txtCodigo.Enabled = false;
                btNovo.Text = "Cancelar";
            }
            else
            {
                btSalvar.Enabled = false;
                btNovo.Text = "Novo";
                txtCodigo.Enabled = true;
            }
            LimparDados();
        }
        public void LimparDados()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCodigo.Text = "";
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text.ToUpper().Trim();
                string email = txtEmail.Text.ToUpper().Trim();

                conexao = Banco.Conexao.getConexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO funcionarios (nome, email, status, imagem)" +
                    "VALUES (@nome,@email, @status, @imagem)";

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@status", true);
                if (fotoEndereco == "")
                {
                    comando.Parameters.AddWithValue("@imagem", null);
                }
                else
                {
                    comando.Parameters.AddWithValue("@imagem", ConverteImagemToByte());
                }

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados graavados com Sucesso!", "Atenção");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar gravar os dados! \n" + ex.Message);
            }
            finally
            {
                conexao.Close();
                btNovo.Text = "Novo";
                btSalvar.Enabled = false;
                LimparDados();
                btNovo.Text = "Novo";
                txtCodigo.Enabled = false;
                ConsultarTodos();
            }
        }

        public byte[] ConverteImagemToByte()
        {
            byte[] imagemByte = null;

            FileStream fs = new FileStream(fotoEndereco, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            imagemByte = br.ReadBytes((int)fs.Length);
            return imagemByte;

        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Enabled == false)
            {
                txtCodigo.Enabled = true;
                btNovo.Text = "Novo";
                btSalvar.Enabled = false;
                LimparDados();
                txtCodigo.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show("Preencha o campo Codigo para consultar", "Atenção");
                    txtCodigo.Focus();
                }
                else
                {
                    try
                    {
                        int codigo = Convert.ToInt16(txtCodigo.Text);
                        ConsultarCodigo(codigo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel efetuar a consulta \n" + ex.Message, "Atenção");
                    }
                }
            }
        }

        public void ConsultarCodigo(int codigo)
        {
            try
            {
                conexao = Banco.Conexao.getConexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "Select * from funcionarios" + 
                    "where status = true and codigo = @codigo";

                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Prepare();

                MySqlDataReader dados = comando.ExecuteReader();

                if (dados.Read())
                {
                    txtCodigo.Text = dados["codigo"].ToString();
                    txtNome.Text = dados["nome"].ToString();
                    txtEmail.Text = dados["email"].ToString();
                    btAlterar.Enabled = true;
                    btExcluir.Enabled = true;

                    if (dados["imagem"] == DBNull.Value)
                    {
                        imagem.Image = null;
                    }
                    else
                    {
                        imagem.Image = ConverteByteToImagem((byte[])dados["imagem"]);
                    }
                }
                else
                {
                    MessageBox.Show("O codigo digitado não foi localizado no banco de dados", "Atenção");
                    LimparDados();
                    txtCodigo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu erro na busca de dados: \n" + ex.Message, "Atenção");
                LimparDados();
                txtCodigo.Focus();
            }
            finally
            {
                conexao.Close();
            }
        }

        public Image ConverteByteToImagem(byte[] imgbytes)
        {
            MemoryStream ms = new MemoryStream(imgbytes);
            return Image.FromStream(ms);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConsultarTodos();
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
        }

        public void ConsultarTodos()
        {
            try
            {
                conexao = Banco.Conexao.getConexao();
                conexao.Open();

                string sql = "SELECT Codigo, Nome, Email FROM funcionarios" +
                    "WHERE status ORDER BY nome";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);

                da.Fill(dt);

                dgvFuncionarios.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conexao.Close();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text) || txtCodigo.Text.Length == 0)
                {
                    MessageBox.Show("Preencha os campos Nome e E-mail para a alteração!", "Atenção");
                }
                else
                {
                    int codigo = Convert.ToInt16(txtCodigo.Text);
                    string nome = txtNome.Text.ToString().ToUpper();
                    string email = txtEmail.Text.ToString().ToUpper();

                    conexao = Banco.Conexao.getConexao();
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "UPDATE funcionario set nome = @nome, email = @email " + 
                        "imagem = @imagem WHERE codigo = @codigo";

                    comando.Parameters.AddWithValue("codigo", codigo);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@email", email);
                    if (fotoEndereco == "")
                    {
                        comando.Parameters.AddWithValue("@imagem", null);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("imagem", ConverteImagemToByte());
                    }

                    comando.Prepare();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados Alterados com Sucesso!", "Atenção");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar Dados! \n" + ex.Message, "Atenção");
            }
            finally
            {
                conexao.Close();
                LimparDados();
                ConsultarTodos();
            }
        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int linha = e.RowIndex;

                DataGridViewRow selecao = dgvFuncionarios.Rows[linha];
                int codigo = Convert.ToInt16(selecao.Cells[0].Value);
            }
            catch (Exception ex)
            {

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("deseja excluir?", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int codigo = Convert.ToInt16(txtCodigo.Text);

                    conexao = Banco.Conexao.getConexao();
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = conexao;
                    //comando.CommandText = "DELATE FROM funcionarios WHERE codigo = @codigo";
                    comando.CommandText = "UPDATE FROM funcionarios WHERE codigo = @codigo";

                    comando.Parameters.AddWithValue("@codigo", codigo);

                    comando.Prepare();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Registro Excluido com sucesso!", "Atenção");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu erro ao excluir! \n" + ex.Message, "Atenção");
                }
                finally
                {
                    conexao.Close();
                    LimparDados();
                    ConsultarTodos();
                }
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.Filter = "Imagens(*.jpg;*.png) | *.jpg; *.png;";
            if (janela.ShowDialog() == DialogResult.OK)
            {
                fotoEndereco = janela.ToString();
                imagem.ImageLocation = fotoEndereco;
            }
        }
    }
}