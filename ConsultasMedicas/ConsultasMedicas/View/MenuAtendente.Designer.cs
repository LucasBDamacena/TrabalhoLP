namespace ConsultasMedicas
{
    partial class MenuAtendente
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.btnConsultasRealizadas = new System.Windows.Forms.Button();
            this.btnConsultasAbertas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Belwe Cn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE CONSULTAS MÉDICAS";
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNovaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovaConsulta.Location = new System.Drawing.Point(38, 76);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(146, 132);
            this.btnNovaConsulta.TabIndex = 2;
            this.btnNovaConsulta.Text = "NOVA CONSULTA";
            this.btnNovaConsulta.UseVisualStyleBackColor = false;
            this.btnNovaConsulta.Click += new System.EventHandler(this.btnNovaConsulta_Click);
            // 
            // btnConsultasRealizadas
            // 
            this.btnConsultasRealizadas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsultasRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultasRealizadas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultasRealizadas.Location = new System.Drawing.Point(460, 76);
            this.btnConsultasRealizadas.Name = "btnConsultasRealizadas";
            this.btnConsultasRealizadas.Size = new System.Drawing.Size(146, 132);
            this.btnConsultasRealizadas.TabIndex = 3;
            this.btnConsultasRealizadas.Text = "CONSULTAS REALIZADAS";
            this.btnConsultasRealizadas.UseVisualStyleBackColor = false;
            this.btnConsultasRealizadas.Click += new System.EventHandler(this.btnConsultasRealizadas_Click);
            // 
            // btnConsultasAbertas
            // 
            this.btnConsultasAbertas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsultasAbertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultasAbertas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultasAbertas.Location = new System.Drawing.Point(256, 76);
            this.btnConsultasAbertas.Name = "btnConsultasAbertas";
            this.btnConsultasAbertas.Size = new System.Drawing.Size(146, 132);
            this.btnConsultasAbertas.TabIndex = 4;
            this.btnConsultasAbertas.Text = "CONSULTAS EM ABERTO";
            this.btnConsultasAbertas.UseVisualStyleBackColor = false;
            this.btnConsultasAbertas.Click += new System.EventHandler(this.btnConsultasAbertas_Click);
            // 
            // MenuAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 220);
            this.Controls.Add(this.btnConsultasAbertas);
            this.Controls.Add(this.btnConsultasRealizadas);
            this.Controls.Add(this.btnNovaConsulta);
            this.Controls.Add(this.label1);
            this.Name = "MenuAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovaConsulta;
        private System.Windows.Forms.Button btnConsultasRealizadas;
        private System.Windows.Forms.Button btnConsultasAbertas;
    }
}

