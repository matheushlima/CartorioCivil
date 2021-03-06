﻿namespace CartorioCivil
{
    partial class Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRelatTXT = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.txtDataRegistroAte = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 74);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registro de Nascimento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "DE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "DATA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "ATÉ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRelatTXT
            // 
            this.btnRelatTXT.BackColor = System.Drawing.Color.Black;
            this.btnRelatTXT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRelatTXT.Location = new System.Drawing.Point(299, 197);
            this.btnRelatTXT.Name = "btnRelatTXT";
            this.btnRelatTXT.Size = new System.Drawing.Size(200, 40);
            this.btnRelatTXT.TabIndex = 20;
            this.btnRelatTXT.Text = "RELATORIO TXT";
            this.btnRelatTXT.UseVisualStyleBackColor = false;
            this.btnRelatTXT.Click += new System.EventHandler(this.btnRelatTXT_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(313, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(176, 40);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDataRegistro
            // 
            this.txtDataRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRegistro.Location = new System.Drawing.Point(298, 131);
            this.txtDataRegistro.Mask = "00/00/0000";
            this.txtDataRegistro.Name = "txtDataRegistro";
            this.txtDataRegistro.Size = new System.Drawing.Size(90, 26);
            this.txtDataRegistro.TabIndex = 24;
            this.txtDataRegistro.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataRegistroAte
            // 
            this.txtDataRegistroAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRegistroAte.Location = new System.Drawing.Point(482, 131);
            this.txtDataRegistroAte.Mask = "00/00/0000";
            this.txtDataRegistroAte.Name = "txtDataRegistroAte";
            this.txtDataRegistroAte.Size = new System.Drawing.Size(90, 26);
            this.txtDataRegistroAte.TabIndex = 25;
            this.txtDataRegistroAte.ValidatingType = typeof(System.DateTime);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.txtDataRegistroAte);
            this.Controls.Add(this.txtDataRegistro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRelatTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRelatTXT;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtDataRegistro;
        private System.Windows.Forms.MaskedTextBox txtDataRegistroAte;
    }
}