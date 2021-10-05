﻿
namespace FarmaTech.View.Principal
{
    partial class TelaMovimentacaoFinanceira
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnContasReceber = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnContasPagar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagarCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbPagar = new System.Windows.Forms.RadioButton();
            this.rbReceber = new System.Windows.Forms.RadioButton();
            this.rbTudo = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblMovimentacaoFinanceira = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnContasReceber);
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Controls.Add(this.btnContasPagar);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.rbPagar);
            this.panel1.Controls.Add(this.rbReceber);
            this.panel1.Controls.Add(this.rbTudo);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblAte);
            this.panel1.Controls.Add(this.lblPeriodo);
            this.panel1.Controls.Add(this.lblMovimentacaoFinanceira);
            this.panel1.Location = new System.Drawing.Point(54, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 625);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnContasReceber
            // 
            this.btnContasReceber.Location = new System.Drawing.Point(574, 539);
            this.btnContasReceber.Name = "btnContasReceber";
            this.btnContasReceber.Size = new System.Drawing.Size(93, 41);
            this.btnContasReceber.TabIndex = 93;
            this.btnContasReceber.Text = "Contas a Receber";
            this.btnContasReceber.UseVisualStyleBackColor = true;
            this.btnContasReceber.Click += new System.EventHandler(this.btnContasReceber_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(708, 539);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(105, 42);
            this.btnRelatorio.TabIndex = 92;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnContasPagar
            // 
            this.btnContasPagar.Location = new System.Drawing.Point(441, 539);
            this.btnContasPagar.Name = "btnContasPagar";
            this.btnContasPagar.Size = new System.Drawing.Size(93, 41);
            this.btnContasPagar.TabIndex = 91;
            this.btnContasPagar.Text = "Contas a Pagar";
            this.btnContasPagar.UseVisualStyleBackColor = true;
            this.btnContasPagar.Click += new System.EventHandler(this.btnContasPagar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::FarmaTech.Properties.Resources.BotaoHome;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(285, 512);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 95);
            this.btnVoltar.TabIndex = 90;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataCol,
            this.ReceberCol,
            this.PagarCol,
            this.DescricaoCol});
            this.dataGridView1.Location = new System.Drawing.Point(61, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(968, 317);
            this.dataGridView1.TabIndex = 8;
            // 
            // DataCol
            // 
            this.DataCol.HeaderText = "Data";
            this.DataCol.Name = "DataCol";
            this.DataCol.ReadOnly = true;
            // 
            // ReceberCol
            // 
            this.ReceberCol.HeaderText = "Receber";
            this.ReceberCol.Name = "ReceberCol";
            this.ReceberCol.ReadOnly = true;
            // 
            // PagarCol
            // 
            this.PagarCol.HeaderText = "Pagar";
            this.PagarCol.Name = "PagarCol";
            this.PagarCol.ReadOnly = true;
            // 
            // DescricaoCol
            // 
            this.DescricaoCol.HeaderText = "Descrição";
            this.DescricaoCol.Name = "DescricaoCol";
            this.DescricaoCol.ReadOnly = true;
            // 
            // rbPagar
            // 
            this.rbPagar.AutoSize = true;
            this.rbPagar.BackColor = System.Drawing.Color.Transparent;
            this.rbPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPagar.Location = new System.Drawing.Point(878, 122);
            this.rbPagar.Name = "rbPagar";
            this.rbPagar.Size = new System.Drawing.Size(74, 24);
            this.rbPagar.TabIndex = 7;
            this.rbPagar.TabStop = true;
            this.rbPagar.Text = "Pagar";
            this.rbPagar.UseVisualStyleBackColor = false;
            this.rbPagar.CheckedChanged += new System.EventHandler(this.rbPagar_CheckedChanged);
            // 
            // rbReceber
            // 
            this.rbReceber.AutoSize = true;
            this.rbReceber.BackColor = System.Drawing.Color.Transparent;
            this.rbReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReceber.Location = new System.Drawing.Point(878, 80);
            this.rbReceber.Name = "rbReceber";
            this.rbReceber.Size = new System.Drawing.Size(95, 24);
            this.rbReceber.TabIndex = 6;
            this.rbReceber.TabStop = true;
            this.rbReceber.Text = "Receber";
            this.rbReceber.UseVisualStyleBackColor = false;
            this.rbReceber.CheckedChanged += new System.EventHandler(this.rbReceber_CheckedChanged);
            // 
            // rbTudo
            // 
            this.rbTudo.AutoSize = true;
            this.rbTudo.BackColor = System.Drawing.Color.Transparent;
            this.rbTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTudo.Location = new System.Drawing.Point(878, 35);
            this.rbTudo.Name = "rbTudo";
            this.rbTudo.Size = new System.Drawing.Size(157, 24);
            this.rbTudo.TabIndex = 5;
            this.rbTudo.TabStop = true;
            this.rbTudo.Text = "Receber / Pagar";
            this.rbTudo.UseVisualStyleBackColor = false;
            this.rbTudo.CheckedChanged += new System.EventHandler(this.rbTudo_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(392, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.BackColor = System.Drawing.Color.Transparent;
            this.lblAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.Location = new System.Drawing.Point(345, 113);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(35, 20);
            this.lblAte.TabIndex = 2;
            this.lblAte.Text = "até";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(57, 112);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(75, 20);
            this.lblPeriodo.TabIndex = 1;
            this.lblPeriodo.Text = "Período:";
            // 
            // lblMovimentacaoFinanceira
            // 
            this.lblMovimentacaoFinanceira.AutoSize = true;
            this.lblMovimentacaoFinanceira.BackColor = System.Drawing.Color.Transparent;
            this.lblMovimentacaoFinanceira.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimentacaoFinanceira.Location = new System.Drawing.Point(318, 35);
            this.lblMovimentacaoFinanceira.Name = "lblMovimentacaoFinanceira";
            this.lblMovimentacaoFinanceira.Size = new System.Drawing.Size(406, 37);
            this.lblMovimentacaoFinanceira.TabIndex = 0;
            this.lblMovimentacaoFinanceira.Text = "Movimentação Financeira";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 703);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 30);
            this.panel2.TabIndex = 92;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblHora.Location = new System.Drawing.Point(1095, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 87;
            this.lblHora.Text = "Hora";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblData.Location = new System.Drawing.Point(12, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 13);
            this.lblData.TabIndex = 86;
            this.lblData.Text = "Data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaMovimentacaoFinanceira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaMovimentacaoFinanceira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaMovimentacaoFinanceira";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaMovimentacaoFinanceira_FormClosed);
            this.Load += new System.EventHandler(this.TelaMovimentacaoFinanceira_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaMovimentacaoFinanceira_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbPagar;
        private System.Windows.Forms.RadioButton rbReceber;
        private System.Windows.Forms.RadioButton rbTudo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblMovimentacaoFinanceira;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagarCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoCol;
        private System.Windows.Forms.Button btnContasReceber;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnContasPagar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
    }
}