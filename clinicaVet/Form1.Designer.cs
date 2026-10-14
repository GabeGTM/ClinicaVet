namespace clinicaVet
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
            this.clinicaVet = new System.Windows.Forms.Button();
            this.texto1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tutor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clinicaVet
            // 
            this.clinicaVet.BackColor = System.Drawing.Color.Gainsboro;
            this.clinicaVet.FlatAppearance.BorderSize = 0;
            this.clinicaVet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clinicaVet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clinicaVet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clinicaVet.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicaVet.ForeColor = System.Drawing.Color.Black;
            this.clinicaVet.Location = new System.Drawing.Point(88, 155);
            this.clinicaVet.Margin = new System.Windows.Forms.Padding(1);
            this.clinicaVet.Name = "clinicaVet";
            this.clinicaVet.Size = new System.Drawing.Size(298, 63);
            this.clinicaVet.TabIndex = 2;
            this.clinicaVet.Text = "Clínica Vet";
            this.clinicaVet.UseMnemonic = false;
            this.clinicaVet.UseVisualStyleBackColor = false;
            this.clinicaVet.Click += new System.EventHandler(this.clinicaVet_Click);
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.BackColor = System.Drawing.Color.Transparent;
            this.texto1.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto1.ForeColor = System.Drawing.Color.Black;
            this.texto1.Location = new System.Drawing.Point(44, 15);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(384, 49);
            this.texto1.TabIndex = 3;
            this.texto1.Text = "Fazer Atendimento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.texto1);
            this.panel1.Controls.Add(this.clinicaVet);
            this.panel1.Controls.Add(this.tutor);
            this.panel1.Location = new System.Drawing.Point(114, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 281);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tutor
            // 
            this.tutor.BackColor = System.Drawing.Color.Gainsboro;
            this.tutor.FlatAppearance.BorderSize = 0;
            this.tutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.tutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutor.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutor.ForeColor = System.Drawing.Color.Black;
            this.tutor.Location = new System.Drawing.Point(88, 89);
            this.tutor.Margin = new System.Windows.Forms.Padding(1);
            this.tutor.Name = "tutor";
            this.tutor.Size = new System.Drawing.Size(298, 49);
            this.tutor.TabIndex = 1;
            this.tutor.Text = "Tutor";
            this.tutor.UseMnemonic = false;
            this.tutor.UseVisualStyleBackColor = false;
            this.tutor.Click += new System.EventHandler(this.tutor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clinicaVet;
        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tutor;
    }
}

