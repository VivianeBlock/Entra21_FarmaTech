﻿
namespace FarmaTech.View.Requisicoes
{
    partial class TelaNovaRequisicao
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
            this.cbFilial = new System.Windows.Forms.ComboBox();
            this.lblFilial = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDataSistema = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFilial
            // 
            this.cbFilial.FormattingEnabled = true;
            this.cbFilial.Location = new System.Drawing.Point(154, 94);
            this.cbFilial.Name = "cbFilial";
            this.cbFilial.Size = new System.Drawing.Size(184, 21);
            this.cbFilial.TabIndex = 19;
            // 
            // lblFilial
            // 
            this.lblFilial.AutoSize = true;
            this.lblFilial.Location = new System.Drawing.Point(83, 97);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(30, 13);
            this.lblFilial.TabIndex = 18;
            this.lblFilial.Text = "Filial:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(154, 211);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(527, 118);
            this.txtDescricao.TabIndex = 17;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(40, 214);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(154, 158);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(527, 20);
            this.txtAssunto.TabIndex = 15;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(54, 161);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(48, 13);
            this.lblAssunto.TabIndex = 14;
            this.lblAssunto.Text = "Assunto:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(482, 37);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(184, 21);
            this.cbUsuario.TabIndex = 13;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(385, 40);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblDataSistema
            // 
            this.lblDataSistema.AutoSize = true;
            this.lblDataSistema.Location = new System.Drawing.Point(150, 34);
            this.lblDataSistema.Name = "lblDataSistema";
            this.lblDataSistema.Size = new System.Drawing.Size(0, 13);
            this.lblDataSistema.TabIndex = 11;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(81, 34);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.cbFilial);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblFilial);
            this.panel1.Controls.Add(this.lblDataSistema);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.cbUsuario);
            this.panel1.Controls.Add(this.txtAssunto);
            this.panel1.Controls.Add(this.lblAssunto);
            this.panel1.Location = new System.Drawing.Point(154, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 378);
            this.panel1.TabIndex = 20;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::FarmaTech.Properties.Resources.BotaoSalvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(29, 155);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 95);
            this.btnSalvar.TabIndex = 87;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::FarmaTech.Properties.Resources.BotaoHome;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(29, 54);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 95);
            this.btnVoltar.TabIndex = 86;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // TelaNovaRequisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 474);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaNovaRequisicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Nova Requisição";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaNovaRequisicao_FormClosed);
            this.Load += new System.EventHandler(this.TelaNovaRequisicao_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaNovaRequisicao_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilial;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDataSistema;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
    }
}