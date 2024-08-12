namespace EmprestimoLivros.WindowsForms.View
{
    partial class FrmClienteScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcliId = new System.Windows.Forms.TextBox();
            this.txtcliNome = new System.Windows.Forms.TextBox();
            this.txtcliCPF = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcliEndereco = new System.Windows.Forms.TextBox();
            this.txtcliNumero = new System.Windows.Forms.TextBox();
            this.txtcliBairro = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcliCidade = new System.Windows.Forms.TextBox();
            this.txtcliTelefoneFixo = new System.Windows.Forms.TextBox();
            this.txtcliTelefoneCelular = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
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
            this.lbltitulo.Size = new System.Drawing.Size(85, 25);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Clientes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtcliId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtcliNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtcliCPF, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 48);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CPF";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome do Cliente";
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
            // txtcliId
            // 
            this.txtcliId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcliId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliId.Location = new System.Drawing.Point(3, 23);
            this.txtcliId.Name = "txtcliId";
            this.txtcliId.ReadOnly = true;
            this.txtcliId.Size = new System.Drawing.Size(74, 23);
            this.txtcliId.TabIndex = 1;
            this.txtcliId.TabStop = false;
            this.txtcliId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcliNome
            // 
            this.txtcliNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcliNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcliNome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliNome.Location = new System.Drawing.Point(83, 23);
            this.txtcliNome.Name = "txtcliNome";
            this.txtcliNome.Size = new System.Drawing.Size(486, 23);
            this.txtcliNome.TabIndex = 1;
            // 
            // txtcliCPF
            // 
            this.txtcliCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcliCPF.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliCPF.Location = new System.Drawing.Point(575, 23);
            this.txtcliCPF.Name = "txtcliCPF";
            this.txtcliCPF.Size = new System.Drawing.Size(198, 23);
            this.txtcliCPF.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 306F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtcliEndereco, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtcliNumero, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtcliBairro, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 112);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(777, 48);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(474, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Endereço";
            // 
            // txtcliEndereco
            // 
            this.txtcliEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcliEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcliEndereco.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliEndereco.Location = new System.Drawing.Point(3, 23);
            this.txtcliEndereco.Name = "txtcliEndereco";
            this.txtcliEndereco.Size = new System.Drawing.Size(365, 23);
            this.txtcliEndereco.TabIndex = 1;
            // 
            // txtcliNumero
            // 
            this.txtcliNumero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcliNumero.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliNumero.Location = new System.Drawing.Point(374, 23);
            this.txtcliNumero.Name = "txtcliNumero";
            this.txtcliNumero.Size = new System.Drawing.Size(94, 23);
            this.txtcliNumero.TabIndex = 1;
            // 
            // txtcliBairro
            // 
            this.txtcliBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcliBairro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcliBairro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliBairro.Location = new System.Drawing.Point(474, 23);
            this.txtcliBairro.Name = "txtcliBairro";
            this.txtcliBairro.Size = new System.Drawing.Size(300, 23);
            this.txtcliBairro.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtcliCidade, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtcliTelefoneFixo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtcliTelefoneCelular, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 164);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(777, 48);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(579, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Telefone Celular";
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(374, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Telefone Fixo";
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(365, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cidade";
            // 
            // txtcliCidade
            // 
            this.txtcliCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcliCidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcliCidade.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliCidade.Location = new System.Drawing.Point(3, 23);
            this.txtcliCidade.Name = "txtcliCidade";
            this.txtcliCidade.Size = new System.Drawing.Size(365, 23);
            this.txtcliCidade.TabIndex = 1;
            // 
            // txtcliTelefoneFixo
            // 
            this.txtcliTelefoneFixo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcliTelefoneFixo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliTelefoneFixo.Location = new System.Drawing.Point(374, 23);
            this.txtcliTelefoneFixo.Name = "txtcliTelefoneFixo";
            this.txtcliTelefoneFixo.Size = new System.Drawing.Size(199, 23);
            this.txtcliTelefoneFixo.TabIndex = 1;
            // 
            // txtcliTelefoneCelular
            // 
            this.txtcliTelefoneCelular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcliTelefoneCelular.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliTelefoneCelular.Location = new System.Drawing.Point(579, 23);
            this.txtcliTelefoneCelular.Name = "txtcliTelefoneCelular";
            this.txtcliTelefoneCelular.Size = new System.Drawing.Size(195, 23);
            this.txtcliTelefoneCelular.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnSalvar.Location = new System.Drawing.Point(15, 216);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 15;
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
            this.btnCancelar.Location = new System.Drawing.Point(710, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmClienteScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 258);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestimo de Livros | Clientes";
            this.Load += new System.EventHandler(this.FrmClienteScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtcliId;
        private System.Windows.Forms.TextBox txtcliNome;
        private System.Windows.Forms.TextBox txtcliCPF;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcliEndereco;
        private System.Windows.Forms.TextBox txtcliNumero;
        private System.Windows.Forms.TextBox txtcliBairro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcliCidade;
        private System.Windows.Forms.TextBox txtcliTelefoneFixo;
        private System.Windows.Forms.TextBox txtcliTelefoneCelular;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}