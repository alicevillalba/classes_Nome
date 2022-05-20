namespace Classes_Nome
{
    partial class FrmAlimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormPrefeito = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormLoja = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormAlimento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtValor10Aumento = new System.Windows.Forms.TextBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.txtCalorias = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.lblValor10Aumento = new System.Windows.Forms.Label();
            this.lblCalorias = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem1
            // 
            this.exibirToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFormPrefeito,
            this.exibirFormLoja,
            this.exibirFormAlimento});
            this.exibirToolStripMenuItem1.Name = "exibirToolStripMenuItem1";
            this.exibirToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem1.Text = "Exibir";
            // 
            // exibirFormPrefeito
            // 
            this.exibirFormPrefeito.Name = "exibirFormPrefeito";
            this.exibirFormPrefeito.Size = new System.Drawing.Size(154, 22);
            this.exibirFormPrefeito.Text = "Form Prefeito";
            this.exibirFormPrefeito.Click += new System.EventHandler(this.exibirFormPrefeito_Click);
            // 
            // exibirFormLoja
            // 
            this.exibirFormLoja.Name = "exibirFormLoja";
            this.exibirFormLoja.Size = new System.Drawing.Size(154, 22);
            this.exibirFormLoja.Text = "Form Loja";
            this.exibirFormLoja.Click += new System.EventHandler(this.exibirFormLoja_Click);
            // 
            // exibirFormAlimento
            // 
            this.exibirFormAlimento.Name = "exibirFormAlimento";
            this.exibirFormAlimento.Size = new System.Drawing.Size(154, 22);
            this.exibirFormAlimento.Text = "Form Alimento";
            this.exibirFormAlimento.Click += new System.EventHandler(this.exibirFormAlimento_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(350, 330);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 33);
            this.btnLimpar.TabIndex = 59;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(212, 330);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(109, 33);
            this.btnCadastrar.TabIndex = 58;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // txtValor10Aumento
            // 
            this.txtValor10Aumento.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor10Aumento.Location = new System.Drawing.Point(441, 250);
            this.txtValor10Aumento.Name = "txtValor10Aumento";
            this.txtValor10Aumento.Size = new System.Drawing.Size(183, 23);
            this.txtValor10Aumento.TabIndex = 53;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.Location = new System.Drawing.Point(266, 136);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(358, 23);
            this.txtIngredientes.TabIndex = 50;
            // 
            // txtCalorias
            // 
            this.txtCalorias.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalorias.Location = new System.Drawing.Point(64, 250);
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.Size = new System.Drawing.Size(148, 23);
            this.txtCalorias.TabIndex = 49;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.Location = new System.Drawing.Point(266, 250);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(136, 23);
            this.txtValorCompra.TabIndex = 48;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(61, 136);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(151, 23);
            this.txtNome.TabIndex = 47;
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.Location = new System.Drawing.Point(263, 220);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(107, 17);
            this.lblValorCompra.TabIndex = 46;
            this.lblValorCompra.Text = "Valor de compra";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.Location = new System.Drawing.Point(263, 106);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(81, 17);
            this.lblIngredientes.TabIndex = 45;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // lblValor10Aumento
            // 
            this.lblValor10Aumento.AutoSize = true;
            this.lblValor10Aumento.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor10Aumento.Location = new System.Drawing.Point(438, 220);
            this.lblValor10Aumento.Name = "lblValor10Aumento";
            this.lblValor10Aumento.Size = new System.Drawing.Size(171, 17);
            this.lblValor10Aumento.TabIndex = 39;
            this.lblValor10Aumento.Text = "Valor com 10% de aumento";
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalorias.Location = new System.Drawing.Point(61, 220);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(55, 17);
            this.lblCalorias.TabIndex = 37;
            this.lblCalorias.Text = "Calorias";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(58, 106);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 17);
            this.lblNome.TabIndex = 36;
            this.lblNome.Text = "Nome";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(217, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 26);
            this.lblTitulo.TabIndex = 60;
            this.lblTitulo.Text = "Cadastro de Alimento";
            // 
            // FrmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(671, 407);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtValor10Aumento);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.txtCalorias);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.lblValor10Aumento);
            this.Controls.Add(this.lblCalorias);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAlimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alimento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exibirFormPrefeito;
        private System.Windows.Forms.ToolStripMenuItem exibirFormLoja;
        private System.Windows.Forms.ToolStripMenuItem exibirFormAlimento;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtValor10Aumento;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.TextBox txtCalorias;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.Label lblValor10Aumento;
        private System.Windows.Forms.Label lblCalorias;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitulo;
    }
}