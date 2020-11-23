namespace CartorioCivil
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNascimento = new System.Windows.Forms.Button();
            this.btnCasamento = new System.Windows.Forms.Button();
            this.btnObito = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARTÓRIO CIVIL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNascimento
            // 
            this.btnNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNascimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNascimento.FlatAppearance.BorderSize = 0;
            this.btnNascimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNascimento.Location = new System.Drawing.Point(156, 103);
            this.btnNascimento.Name = "btnNascimento";
            this.btnNascimento.Size = new System.Drawing.Size(199, 58);
            this.btnNascimento.TabIndex = 1;
            this.btnNascimento.Text = "NASCIMENTO";
            this.btnNascimento.UseVisualStyleBackColor = false;
            this.btnNascimento.Click += new System.EventHandler(this.btnNascimento_Click);
            // 
            // btnCasamento
            // 
            this.btnCasamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCasamento.FlatAppearance.BorderSize = 0;
            this.btnCasamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasamento.Location = new System.Drawing.Point(156, 167);
            this.btnCasamento.Name = "btnCasamento";
            this.btnCasamento.Size = new System.Drawing.Size(199, 58);
            this.btnCasamento.TabIndex = 3;
            this.btnCasamento.Text = "CASAMENTO";
            this.btnCasamento.UseVisualStyleBackColor = false;
            this.btnCasamento.Click += new System.EventHandler(this.btnCasamento_Click);
            // 
            // btnObito
            // 
            this.btnObito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnObito.FlatAppearance.BorderSize = 0;
            this.btnObito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObito.Location = new System.Drawing.Point(156, 231);
            this.btnObito.Name = "btnObito";
            this.btnObito.Size = new System.Drawing.Size(199, 58);
            this.btnObito.TabIndex = 4;
            this.btnObito.Text = "ÓBITO";
            this.btnObito.UseVisualStyleBackColor = false;
            this.btnObito.Click += new System.EventHandler(this.btnObito_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(156, 295);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(199, 58);
            this.btnRelatorio.TabIndex = 5;
            this.btnRelatorio.Text = "RELATÓRIO";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(533, 368);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnObito);
            this.Controls.Add(this.btnCasamento);
            this.Controls.Add(this.btnNascimento);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNascimento;
        private System.Windows.Forms.Button btnCasamento;
        private System.Windows.Forms.Button btnObito;
        private System.Windows.Forms.Button btnRelatorio;
    }
}

