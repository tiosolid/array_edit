namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.txtArrayEntrada = new System.Windows.Forms.TextBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerarSaida = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtArraySaida = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtMainDados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMainTag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsciiHex = new System.Windows.Forms.Button();
            this.txtAscii = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtHexEntrada = new System.Windows.Forms.TextBox();
            this.TxtHexaSaida = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtTAG = new System.Windows.Forms.TextBox();
            this.TxtLENGTH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelHELP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArrayEntrada
            // 
            this.txtArrayEntrada.Location = new System.Drawing.Point(6, 19);
            this.txtArrayEntrada.Multiline = true;
            this.txtArrayEntrada.Name = "txtArrayEntrada";
            this.txtArrayEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArrayEntrada.Size = new System.Drawing.Size(600, 40);
            this.txtArrayEntrada.TabIndex = 0;
            this.txtArrayEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArrayEntrada_KeyDown);
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(612, 19);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(75, 40);
            this.btnAnalisar.TabIndex = 1;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnalisar);
            this.groupBox1.Controls.Add(this.txtArrayEntrada);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Array de Entrada";
            // 
            // btnGerarSaida
            // 
            this.btnGerarSaida.Enabled = false;
            this.btnGerarSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarSaida.Location = new System.Drawing.Point(577, 306);
            this.btnGerarSaida.Name = "btnGerarSaida";
            this.btnGerarSaida.Size = new System.Drawing.Size(110, 48);
            this.btnGerarSaida.TabIndex = 4;
            this.btnGerarSaida.Text = "Gerar Saída";
            this.btnGerarSaida.UseVisualStyleBackColor = true;
            this.btnGerarSaida.Click += new System.EventHandler(this.btnGerarSaida_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtArraySaida);
            this.groupBox2.Location = new System.Drawing.Point(12, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Array de Saída";
            // 
            // txtArraySaida
            // 
            this.txtArraySaida.Location = new System.Drawing.Point(6, 19);
            this.txtArraySaida.Multiline = true;
            this.txtArraySaida.Name = "txtArraySaida";
            this.txtArraySaida.ReadOnly = true;
            this.txtArraySaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArraySaida.Size = new System.Drawing.Size(681, 69);
            this.txtArraySaida.TabIndex = 5;
            this.txtArraySaida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArraySaida_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHex);
            this.groupBox3.Controls.Add(this.txtMainDados);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMainTag);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnAsciiHex);
            this.groupBox3.Controls.Add(this.txtAscii);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dgvDados);
            this.groupBox3.Controls.Add(this.btnGerarSaida);
            this.groupBox3.Location = new System.Drawing.Point(12, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 364);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados TLV (Dados incompletos serão preenchidos com F a direita automaticamente)";
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(9, 334);
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(465, 20);
            this.txtHex.TabIndex = 13;
            // 
            // txtMainDados
            // 
            this.txtMainDados.Location = new System.Drawing.Point(120, 19);
            this.txtMainDados.Name = "txtMainDados";
            this.txtMainDados.ReadOnly = true;
            this.txtMainDados.Size = new System.Drawing.Size(567, 20);
            this.txtMainDados.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dados:";
            // 
            // txtMainTag
            // 
            this.txtMainTag.Location = new System.Drawing.Point(44, 19);
            this.txtMainTag.Name = "txtMainTag";
            this.txtMainTag.ReadOnly = true;
            this.txtMainTag.Size = new System.Drawing.Size(23, 20);
            this.txtMainTag.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TAG:";
            // 
            // btnAsciiHex
            // 
            this.btnAsciiHex.Location = new System.Drawing.Point(399, 306);
            this.btnAsciiHex.Name = "btnAsciiHex";
            this.btnAsciiHex.Size = new System.Drawing.Size(75, 23);
            this.btnAsciiHex.TabIndex = 8;
            this.btnAsciiHex.Text = "Converter";
            this.btnAsciiHex.UseVisualStyleBackColor = true;
            this.btnAsciiHex.Click += new System.EventHandler(this.btnAsciiHex_Click);
            // 
            // txtAscii
            // 
            this.txtAscii.Location = new System.Drawing.Point(98, 308);
            this.txtAscii.Name = "txtAscii";
            this.txtAscii.Size = new System.Drawing.Size(295, 20);
            this.txtAscii.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ASCII para HEX:";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tag,
            this.descricao,
            this.dados});
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Location = new System.Drawing.Point(6, 45);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.Size = new System.Drawing.Size(681, 248);
            this.dgvDados.TabIndex = 5;
            // 
            // tag
            // 
            this.tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tag.HeaderText = "Tag";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            this.tag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tag.Width = 32;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 80;
            // 
            // dados
            // 
            this.dados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dados.HeaderText = "Dados";
            this.dados.Name = "dados";
            this.dados.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TxtHexEntrada
            // 
            this.TxtHexEntrada.Location = new System.Drawing.Point(6, 140);
            this.TxtHexEntrada.Multiline = true;
            this.TxtHexEntrada.Name = "TxtHexEntrada";
            this.TxtHexEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHexEntrada.Size = new System.Drawing.Size(321, 59);
            this.TxtHexEntrada.TabIndex = 7;
            // 
            // TxtHexaSaida
            // 
            this.TxtHexaSaida.BackColor = System.Drawing.SystemColors.Window;
            this.TxtHexaSaida.Location = new System.Drawing.Point(0, 17);
            this.TxtHexaSaida.Multiline = true;
            this.TxtHexaSaida.Name = "TxtHexaSaida";
            this.TxtHexaSaida.ReadOnly = true;
            this.TxtHexaSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHexaSaida.Size = new System.Drawing.Size(321, 59);
            this.TxtHexaSaida.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(711, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 529);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hexa to Byte";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 64);
            this.button1.TabIndex = 15;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TxtHexaSaida);
            this.groupBox6.Location = new System.Drawing.Point(12, 260);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(334, 82);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BYTE :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelHELP);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.TxtHexEntrada);
            this.groupBox5.Controls.Add(this.TxtTAG);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.TxtLENGTH);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(12, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(334, 218);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TLV DATA:";
            // 
            // TxtTAG
            // 
            this.TxtTAG.Location = new System.Drawing.Point(6, 41);
            this.TxtTAG.Name = "TxtTAG";
            this.TxtTAG.Size = new System.Drawing.Size(100, 20);
            this.TxtTAG.TabIndex = 17;
            // 
            // TxtLENGTH
            // 
            this.TxtLENGTH.Location = new System.Drawing.Point(6, 88);
            this.TxtLENGTH.Name = "TxtLENGTH";
            this.TxtLENGTH.Size = new System.Drawing.Size(100, 20);
            this.TxtLENGTH.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "TAG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "LENGTH - HEX:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(239, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 58);
            this.button2.TabIndex = 21;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelHELP
            // 
            this.labelHELP.AutoSize = true;
            this.labelHELP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHELP.Location = new System.Drawing.Point(112, 84);
            this.labelHELP.Name = "labelHELP";
            this.labelHELP.Size = new System.Drawing.Size(185, 24);
            this.labelHELP.TabIndex = 22;
            this.labelHELP.Text = "Caso LENGHT >= 127.\r\nInserimos 81 após a TAG automaticamente.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "VALUE:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 545);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Array Edit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtArrayEntrada;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerarSaida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtArraySaida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnAsciiHex;
        private System.Windows.Forms.TextBox txtAscii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMainTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtMainDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dados;
        private System.Windows.Forms.TextBox TxtHexEntrada;
        private System.Windows.Forms.TextBox TxtHexaSaida;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtLENGTH;
        private System.Windows.Forms.TextBox TxtTAG;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelHELP;
        private System.Windows.Forms.Label label6;
    }
}

