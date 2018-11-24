namespace ConsultasMedicas.View
{
    partial class MenuMedico
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
            this.btnConsultasAbertas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultasRealizadas = new System.Windows.Forms.Button();
            this.labelMedico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultasAbertas
            // 
            this.btnConsultasAbertas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsultasAbertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultasAbertas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultasAbertas.Location = new System.Drawing.Point(26, 95);
            this.btnConsultasAbertas.Name = "btnConsultasAbertas";
            this.btnConsultasAbertas.Size = new System.Drawing.Size(276, 132);
            this.btnConsultasAbertas.TabIndex = 6;
            this.btnConsultasAbertas.Text = "CONSULTAS EM ABERTO";
            this.btnConsultasAbertas.UseVisualStyleBackColor = false;
            this.btnConsultasAbertas.Click += new System.EventHandler(this.btnConsultasAbertas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Belwe Cn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "SISTEMA DE CONSULTAS MÉDICAS";
            // 
            // btnConsultasRealizadas
            // 
            this.btnConsultasRealizadas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsultasRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultasRealizadas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultasRealizadas.Location = new System.Drawing.Point(328, 95);
            this.btnConsultasRealizadas.Name = "btnConsultasRealizadas";
            this.btnConsultasRealizadas.Size = new System.Drawing.Size(276, 132);
            this.btnConsultasRealizadas.TabIndex = 7;
            this.btnConsultasRealizadas.Text = "CONSULTAS REALIZADAS";
            this.btnConsultasRealizadas.UseVisualStyleBackColor = false;
            this.btnConsultasRealizadas.Click += new System.EventHandler(this.btnConsultasRealizadas_Click);
            // 
            // labelMedico
            // 
            this.labelMedico.AutoSize = true;
            this.labelMedico.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedico.Location = new System.Drawing.Point(26, 62);
            this.labelMedico.Name = "labelMedico";
            this.labelMedico.Size = new System.Drawing.Size(280, 18);
            this.labelMedico.TabIndex = 8;
            this.labelMedico.Text = "SISTEMA DE CONSULTAS MÉDICAS";
            // 
            // MenuMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 237);
            this.Controls.Add(this.labelMedico);
            this.Controls.Add(this.btnConsultasRealizadas);
            this.Controls.Add(this.btnConsultasAbertas);
            this.Controls.Add(this.label1);
            this.Name = "MenuMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuMedico";
            this.Load += new System.EventHandler(this.MenuMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultasAbertas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultasRealizadas;
        private System.Windows.Forms.Label labelMedico;
    }
}