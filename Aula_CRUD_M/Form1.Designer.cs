namespace Aula_CRUD_M
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            groupBox1 = new GroupBox();
            btExcluir = new Button();
            btAlterar = new Button();
            btSalvar = new Button();
            btNovo = new Button();
            btConsultar = new Button();
            dgvFuncionarios = new DataGridView();
            btBuscar = new Button();
            imagem = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 26);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(402, 46);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 175);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 38);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 225);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 38);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 278);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 38);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(135, 170);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 43);
            txtCodigo.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(126, 222);
            txtNome.Margin = new Padding(6);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(398, 43);
            txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 277);
            txtEmail.Margin = new Padding(6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(398, 43);
            txtEmail.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btExcluir);
            groupBox1.Controls.Add(btAlterar);
            groupBox1.Controls.Add(btSalvar);
            groupBox1.Controls.Add(btNovo);
            groupBox1.Location = new Point(888, 133);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(329, 146);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = SystemColors.Highlight;
            btExcluir.Enabled = false;
            btExcluir.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluir.ForeColor = SystemColors.ControlLightLight;
            btExcluir.Location = new Point(167, 25);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(130, 52);
            btExcluir.TabIndex = 11;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.BackColor = SystemColors.Highlight;
            btAlterar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterar.ForeColor = SystemColors.ControlLightLight;
            btAlterar.Location = new Point(167, 79);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(130, 58);
            btAlterar.TabIndex = 2;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = false;
            btAlterar.Click += btAlterar_Click;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = SystemColors.HotTrack;
            btSalvar.Enabled = false;
            btSalvar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvar.ForeColor = SystemColors.ControlLightLight;
            btSalvar.Location = new Point(28, 83);
            btSalvar.Margin = new Padding(6);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(130, 54);
            btSalvar.TabIndex = 1;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // btNovo
            // 
            btNovo.BackColor = SystemColors.Highlight;
            btNovo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNovo.ForeColor = SystemColors.ControlLightLight;
            btNovo.Location = new Point(29, 25);
            btNovo.Margin = new Padding(6);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(129, 54);
            btNovo.TabIndex = 0;
            btNovo.Text = "Novo";
            btNovo.UseVisualStyleBackColor = false;
            btNovo.Click += btNovo_Click;
            // 
            // btConsultar
            // 
            btConsultar.Image = (Image)resources.GetObject("btConsultar.Image");
            btConsultar.Location = new Point(241, 171);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(64, 42);
            btConsultar.TabIndex = 8;
            btConsultar.UseVisualStyleBackColor = true;
            btConsultar.Click += btConsultar_Click;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(23, 380);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.RowHeadersWidth = 51;
            dgvFuncionarios.Size = new Size(983, 285);
            dgvFuncionarios.TabIndex = 9;
            dgvFuncionarios.CellClick += dgvFuncionarios_CellClick;
            // 
            // btBuscar
            // 
            btBuscar.BackColor = SystemColors.Highlight;
            btBuscar.ForeColor = SystemColors.ControlLightLight;
            btBuscar.Location = new Point(324, 166);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(188, 46);
            btBuscar.TabIndex = 11;
            btBuscar.Text = "Buscar Foto";
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // imagem
            // 
            imagem.Location = new Point(545, 112);
            imagem.Name = "imagem";
            imagem.Size = new Size(303, 208);
            imagem.TabIndex = 12;
            imagem.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 677);
            Controls.Add(imagem);
            Controls.Add(btBuscar);
            Controls.Add(dgvFuncionarios);
            Controls.Add(btConsultar);
            Controls.Add(groupBox1);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Cadastro de Funcionarios";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtEmail;
        private GroupBox groupBox1;
        private Button btSalvar;
        private Button btNovo;
        private Button btConsultar;
        private DataGridView dgvFuncionarios;
        private Button btAlterar;
        private Button btExcluir;
        private Button btBuscar;
        private PictureBox imagem;
    }
}
