
namespace Crud
{
	partial class FrmCadastroCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCliente));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbNovo = new System.Windows.Forms.ToolStripButton();
			this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
			this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
			this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tbsBuscaPorId = new System.Windows.Forms.ToolStripLabel();
			this.tstId = new System.Windows.Forms.ToolStripTextBox();
			this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
			this.ID = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUf = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.mskCep = new System.Windows.Forms.MaskedTextBox();
			this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbSalvar,
            this.tsbCancelar,
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.tbsBuscaPorId,
            this.tstId,
            this.tsbBuscar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(420, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbNovo
			// 
			this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNovo.Image = global::Crud.Properties.Resources.Novo;
			this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNovo.Name = "tsbNovo";
			this.tsbNovo.Size = new System.Drawing.Size(23, 22);
			this.tsbNovo.Text = "Novo";
			this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
			// 
			// tsbSalvar
			// 
			this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSalvar.Image = global::Crud.Properties.Resources.Salvar;
			this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSalvar.Name = "tsbSalvar";
			this.tsbSalvar.Size = new System.Drawing.Size(23, 22);
			this.tsbSalvar.Text = "Salvar";
			this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
			// 
			// tsbCancelar
			// 
			this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCancelar.Image = global::Crud.Properties.Resources.Cancelar;
			this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCancelar.Name = "tsbCancelar";
			this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
			this.tsbCancelar.Text = "Cancelar";
			this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
			// 
			// tsbExcluir
			// 
			this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbExcluir.Image = global::Crud.Properties.Resources.Excluir;
			this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbExcluir.Name = "tsbExcluir";
			this.tsbExcluir.Size = new System.Drawing.Size(23, 22);
			this.tsbExcluir.Text = "Excluir";
			this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tbsBuscaPorId
			// 
			this.tbsBuscaPorId.Name = "tbsBuscaPorId";
			this.tbsBuscaPorId.Size = new System.Drawing.Size(73, 22);
			this.tbsBuscaPorId.Text = "Busca por ID";
			// 
			// tstId
			// 
			this.tstId.Name = "tstId";
			this.tstId.Size = new System.Drawing.Size(100, 25);
			// 
			// tsbBuscar
			// 
			this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbBuscar.Image = global::Crud.Properties.Resources.Buscar;
			this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbBuscar.Name = "tsbBuscar";
			this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
			this.tsbBuscar.Text = "Buscar";
			this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
			// 
			// ID
			// 
			this.ID.AutoSize = true;
			this.ID.Location = new System.Drawing.Point(13, 30);
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(18, 15);
			this.ID.TabIndex = 1;
			this.ID.Text = "ID";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(13, 48);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(52, 23);
			this.txtId.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(74, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nome";
			// 
			// txtNome
			// 
			this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNome.Location = new System.Drawing.Point(74, 49);
			this.txtNome.MaxLength = 50;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(334, 23);
			this.txtNome.TabIndex = 4;
			// 
			// txtEndereco
			// 
			this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEndereco.Location = new System.Drawing.Point(13, 93);
			this.txtEndereco.MaxLength = 50;
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(395, 23);
			this.txtEndereco.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Endereço";
			// 
			// txtBairro
			// 
			this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBairro.Location = new System.Drawing.Point(85, 138);
			this.txtBairro.MaxLength = 50;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(209, 23);
			this.txtBairro.TabIndex = 8;
			this.txtBairro.Text = " ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(85, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Bairro";
			// 
			// txtCidade
			// 
			this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCidade.Location = new System.Drawing.Point(298, 138);
			this.txtCidade.MaxLength = 50;
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(85, 23);
			this.txtCidade.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(298, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "Cidade";
			// 
			// txtUf
			// 
			this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUf.Location = new System.Drawing.Point(387, 138);
			this.txtUf.MaxLength = 2;
			this.txtUf.Name = "txtUf";
			this.txtUf.Size = new System.Drawing.Size(21, 23);
			this.txtUf.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(387, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "UF";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(28, 15);
			this.label7.TabIndex = 13;
			this.label7.Text = "CEP";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 164);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 15);
			this.label8.TabIndex = 15;
			this.label8.Text = "Telefone";
			// 
			// mskCep
			// 
			this.mskCep.Location = new System.Drawing.Point(13, 138);
			this.mskCep.Mask = "00000-999";
			this.mskCep.Name = "mskCep";
			this.mskCep.Size = new System.Drawing.Size(70, 23);
			this.mskCep.TabIndex = 16;
			// 
			// mskTelefone
			// 
			this.mskTelefone.Location = new System.Drawing.Point(13, 182);
			this.mskTelefone.Mask = "(99) 00000-0000";
			this.mskTelefone.Name = "mskTelefone";
			this.mskTelefone.Size = new System.Drawing.Size(99, 23);
			this.mskTelefone.TabIndex = 17;
			// 
			// FrmCadastroCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 216);
			this.Controls.Add(this.mskTelefone);
			this.Controls.Add(this.mskCep);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtUf);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.ID);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmCadastroCliente";
			this.Text = "Cadastro de Clientes";
			this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbNovo;
		private System.Windows.Forms.ToolStripButton tsbSalvar;
		private System.Windows.Forms.ToolStripButton tsbCancelar;
		private System.Windows.Forms.ToolStripButton tsbExcluir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel tbsBuscaPorId;
		private System.Windows.Forms.ToolStripTextBox tstId;
		private System.Windows.Forms.ToolStripButton tsbBuscar;
		private System.Windows.Forms.Label ID;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUf;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MaskedTextBox mskCep;
		private System.Windows.Forms.MaskedTextBox mskTelefone;
	}
}

