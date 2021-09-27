﻿
namespace FarmaTech.View
{
    partial class TelaCadastroUnidades
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUnidades = new System.Windows.Forms.TabPage();
            this.txtPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.dgUnidades = new System.Windows.Forms.DataGridView();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.tabNovaUnidade = new System.Windows.Forms.TabPage();
            this.txtAbreviacao = new System.Windows.Forms.TextBox();
            this.lblAbreviacao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabUnidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnidades)).BeginInit();
            this.tabNovaUnidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUnidades);
            this.tabControl1.Controls.Add(this.tabNovaUnidade);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(133, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUnidades
            // 
            this.tabUnidades.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabUnidades.Controls.Add(this.txtPesquisaUsuario);
            this.tabUnidades.Controls.Add(this.dgUnidades);
            this.tabUnidades.Controls.Add(this.lblPesquisar);
            this.tabUnidades.Location = new System.Drawing.Point(4, 29);
            this.tabUnidades.Name = "tabUnidades";
            this.tabUnidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnidades.Size = new System.Drawing.Size(629, 404);
            this.tabUnidades.TabIndex = 0;
            this.tabUnidades.Text = "Unidades";
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(209, 25);
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(300, 26);
            this.txtPesquisaUsuario.TabIndex = 19;
            // 
            // dgUnidades
            // 
            this.dgUnidades.AllowUserToAddRows = false;
            this.dgUnidades.AllowUserToDeleteRows = false;
            this.dgUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaNome});
            this.dgUnidades.Location = new System.Drawing.Point(50, 77);
            this.dgUnidades.Name = "dgUnidades";
            this.dgUnidades.ReadOnly = true;
            this.dgUnidades.Size = new System.Drawing.Size(515, 281);
            this.dgUnidades.TabIndex = 18;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(110, 28);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(93, 20);
            this.lblPesquisar.TabIndex = 17;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // tabNovaUnidade
            // 
            this.tabNovaUnidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabNovaUnidade.Controls.Add(this.txtAbreviacao);
            this.tabNovaUnidade.Controls.Add(this.lblAbreviacao);
            this.tabNovaUnidade.Controls.Add(this.txtNome);
            this.tabNovaUnidade.Controls.Add(this.lblNome);
            this.tabNovaUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNovaUnidade.Location = new System.Drawing.Point(4, 29);
            this.tabNovaUnidade.Name = "tabNovaUnidade";
            this.tabNovaUnidade.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovaUnidade.Size = new System.Drawing.Size(629, 404);
            this.tabNovaUnidade.TabIndex = 1;
            this.tabNovaUnidade.Text = "Nova Unidade";
            // 
            // txtAbreviacao
            // 
            this.txtAbreviacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbreviacao.Location = new System.Drawing.Point(129, 130);
            this.txtAbreviacao.Name = "txtAbreviacao";
            this.txtAbreviacao.Size = new System.Drawing.Size(93, 26);
            this.txtAbreviacao.TabIndex = 49;
            // 
            // lblAbreviacao
            // 
            this.lblAbreviacao.AutoSize = true;
            this.lblAbreviacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAbreviacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbreviacao.Location = new System.Drawing.Point(20, 133);
            this.lblAbreviacao.Name = "lblAbreviacao";
            this.lblAbreviacao.Size = new System.Drawing.Size(103, 20);
            this.lblAbreviacao.TabIndex = 48;
            this.lblAbreviacao.Text = "Abreviação:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(129, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(453, 26);
            this.txtNome.TabIndex = 47;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(63, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 46;
            this.lblNome.Text = "Nome:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(28, 129);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 75);
            this.btnNovo.TabIndex = 71;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(28, 400);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 75);
            this.btnExcluir.TabIndex = 70;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(28, 309);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 75);
            this.btnAlterar.TabIndex = 69;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(28, 219);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 75);
            this.btnSalvar.TabIndex = 68;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(28, 38);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 75);
            this.btnVoltar.TabIndex = 67;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ColunaNome
            // 
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.ReadOnly = true;
            this.ColunaNome.Width = 200;
            // 
            // TelaCadastroUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroUnidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Cadastro Unidades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastroUnidades_FormClosed);
            this.Load += new System.EventHandler(this.TelaCadastroUnidades_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUnidades.ResumeLayout(false);
            this.tabUnidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnidades)).EndInit();
            this.tabNovaUnidade.ResumeLayout(false);
            this.tabNovaUnidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUnidades;
        private System.Windows.Forms.TabPage tabNovaUnidade;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtPesquisaUsuario;
        private System.Windows.Forms.DataGridView dgUnidades;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtAbreviacao;
        private System.Windows.Forms.Label lblAbreviacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
    }
}