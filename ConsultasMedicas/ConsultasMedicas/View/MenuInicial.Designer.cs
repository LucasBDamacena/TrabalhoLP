namespace ConsultasMedicas.View
{
    partial class MenuInicial
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnAtendente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Belwe Cn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "SISTEMA DE CONSULTAS MÉDICAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "ACESSAR COMO:";
            // 
            // btnMedico
            // 
            this.btnMedico.BackgroundImage = global::ConsultasMedicas.Properties.Resources.medico;
            this.btnMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMedico.Location = new System.Drawing.Point(266, 81);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(159, 131);
            this.btnMedico.TabIndex = 5;
            this.btnMedico.Text = "MÉDICO";
            this.btnMedico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnAtendente
            // 
            this.btnAtendente.BackgroundImage = global::ConsultasMedicas.Properties.Resources.recepcao;
            this.btnAtendente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendente.Location = new System.Drawing.Point(82, 81);
            this.btnAtendente.Name = "btnAtendente";
            this.btnAtendente.Size = new System.Drawing.Size(159, 131);
            this.btnAtendente.TabIndex = 3;
            this.btnAtendente.Text = "ATENDENTE";
            this.btnAtendente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtendente.UseVisualStyleBackColor = true;
            this.btnAtendente.Click += new System.EventHandler(this.btnAtendente_Click);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 224);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtendente);
            this.Controls.Add(this.label2);
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuInicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtendente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMedico;
    }
}