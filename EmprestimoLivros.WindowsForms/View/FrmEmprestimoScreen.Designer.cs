namespace EmprestimoLivros.WindowsForms.View
{
    partial class FrmEmprestimoScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmprestimoScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesqCliente = new System.Windows.Forms.Button();
            this.txtLceId = new System.Windows.Forms.TextBox();
            this.txtLceIdCliente = new System.Windows.Forms.TextBox();
            this.txtCliNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesqLivro = new System.Windows.Forms.Button();
            this.txtLceIdLivro = new System.Windows.Forms.TextBox();
            this.txtLivroNome = new System.Windows.Forms.TextBox();
            this.mskLceDataEmprestimo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskLceDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chbEntregue = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 59);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lbltitulo.Location = new System.Drawing.Point(68, 17);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(123, 25);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Empréstimo";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 509F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPesqCliente, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLceId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLceIdCliente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCliNome, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 48);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código do Cliente";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id";
            // 
            // btnPesqCliente
            // 
            this.btnPesqCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnPesqCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesqCliente.FlatAppearance.BorderSize = 0;
            this.btnPesqCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnPesqCliente.Location = new System.Drawing.Point(197, 23);
            this.btnPesqCliente.Name = "btnPesqCliente";
            this.btnPesqCliente.Size = new System.Drawing.Size(67, 22);
            this.btnPesqCliente.TabIndex = 3;
            this.btnPesqCliente.Text = "Pesquisar";
            this.btnPesqCliente.UseVisualStyleBackColor = false;
            this.btnPesqCliente.Click += new System.EventHandler(this.btnPesqCliente_Click);
            // 
            // txtLceId
            // 
            this.txtLceId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLceId.Location = new System.Drawing.Point(3, 23);
            this.txtLceId.Name = "txtLceId";
            this.txtLceId.ReadOnly = true;
            this.txtLceId.Size = new System.Drawing.Size(74, 23);
            this.txtLceId.TabIndex = 3;
            this.txtLceId.TabStop = false;
            this.txtLceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLceIdCliente
            // 
            this.txtLceIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLceIdCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLceIdCliente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLceIdCliente.Location = new System.Drawing.Point(83, 23);
            this.txtLceIdCliente.Name = "txtLceIdCliente";
            this.txtLceIdCliente.Size = new System.Drawing.Size(108, 23);
            this.txtLceIdCliente.TabIndex = 4;
            this.txtLceIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLceIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLceIdCliente_KeyDown);
            this.txtLceIdCliente.Leave += new System.EventHandler(this.txtLceIdCliente_Leave);
            // 
            // txtCliNome
            // 
            this.txtCliNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCliNome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliNome.Location = new System.Drawing.Point(270, 23);
            this.txtCliNome.Name = "txtCliNome";
            this.txtCliNome.ReadOnly = true;
            this.txtCliNome.Size = new System.Drawing.Size(503, 23);
            this.txtCliNome.TabIndex = 3;
            this.txtCliNome.TabStop = false;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(503, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome do Cliente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnSalvar.Location = new System.Drawing.Point(15, 166);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCancelar.Location = new System.Drawing.Point(710, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPesqLivro, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtLceIdLivro, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtLivroNome, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.mskLceDataEmprestimo, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.mskLceDataEntrega, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.chbEntregue, 5, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 112);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(776, 48);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empréstimo";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código do Livro";
            // 
            // btnPesqLivro
            // 
            this.btnPesqLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnPesqLivro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesqLivro.FlatAppearance.BorderSize = 0;
            this.btnPesqLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqLivro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnPesqLivro.Location = new System.Drawing.Point(107, 23);
            this.btnPesqLivro.Name = "btnPesqLivro";
            this.btnPesqLivro.Size = new System.Drawing.Size(66, 22);
            this.btnPesqLivro.TabIndex = 3;
            this.btnPesqLivro.Text = "Pesquisar";
            this.btnPesqLivro.UseVisualStyleBackColor = false;
            this.btnPesqLivro.Click += new System.EventHandler(this.btnPesqLivro_Click);
            // 
            // txtLceIdLivro
            // 
            this.txtLceIdLivro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLceIdLivro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLceIdLivro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLceIdLivro.Location = new System.Drawing.Point(3, 23);
            this.txtLceIdLivro.Name = "txtLceIdLivro";
            this.txtLceIdLivro.Size = new System.Drawing.Size(98, 23);
            this.txtLceIdLivro.TabIndex = 4;
            this.txtLceIdLivro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLivroNome
            // 
            this.txtLivroNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLivroNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLivroNome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLivroNome.Location = new System.Drawing.Point(179, 23);
            this.txtLivroNome.Name = "txtLivroNome";
            this.txtLivroNome.ReadOnly = true;
            this.txtLivroNome.Size = new System.Drawing.Size(324, 23);
            this.txtLivroNome.TabIndex = 3;
            this.txtLivroNome.TabStop = false;
            // 
            // mskLceDataEmprestimo
            // 
            this.mskLceDataEmprestimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mskLceDataEmprestimo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskLceDataEmprestimo.Location = new System.Drawing.Point(509, 23);
            this.mskLceDataEmprestimo.Mask = "00/00/0000";
            this.mskLceDataEmprestimo.Name = "mskLceDataEmprestimo";
            this.mskLceDataEmprestimo.Size = new System.Drawing.Size(84, 23);
            this.mskLceDataEmprestimo.TabIndex = 5;
            this.mskLceDataEmprestimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(179, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(324, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nome do Livro";
            // 
            // mskLceDataEntrega
            // 
            this.mskLceDataEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mskLceDataEntrega.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskLceDataEntrega.Location = new System.Drawing.Point(599, 23);
            this.mskLceDataEntrega.Mask = "00/00/0000";
            this.mskLceDataEntrega.Name = "mskLceDataEntrega";
            this.mskLceDataEntrega.Size = new System.Drawing.Size(90, 23);
            this.mskLceDataEntrega.TabIndex = 5;
            this.mskLceDataEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(599, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Entregar";
            // 
            // chbEntregue
            // 
            this.chbEntregue.AutoSize = true;
            this.chbEntregue.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.chbEntregue.Location = new System.Drawing.Point(695, 23);
            this.chbEntregue.Name = "chbEntregue";
            this.chbEntregue.Size = new System.Drawing.Size(77, 20);
            this.chbEntregue.TabIndex = 6;
            this.chbEntregue.Text = "Entregue";
            this.chbEntregue.UseVisualStyleBackColor = true;
            // 
            // FrmEmprestimoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 208);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmprestimoScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmLivroScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLceId;
        private System.Windows.Forms.TextBox txtLceIdCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCliNome;
        private System.Windows.Forms.Button btnPesqCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesqLivro;
        private System.Windows.Forms.TextBox txtLceIdLivro;
        private System.Windows.Forms.TextBox txtLivroNome;
        private System.Windows.Forms.MaskedTextBox mskLceDataEmprestimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskLceDataEntrega;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chbEntregue;
    }
}