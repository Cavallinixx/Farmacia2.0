namespace FarmaciaBD2._0
{
    partial class Farma
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
            this.nao = new System.Windows.Forms.Button();
            this.sim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nao
            // 
            this.nao.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nao.Location = new System.Drawing.Point(188, 227);
            this.nao.Name = "nao";
            this.nao.Size = new System.Drawing.Size(145, 58);
            this.nao.TabIndex = 4;
            this.nao.Text = "Não";
            this.nao.UseVisualStyleBackColor = true;
            this.nao.Click += new System.EventHandler(this.nao_Click);
            // 
            // sim
            // 
            this.sim.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sim.Location = new System.Drawing.Point(26, 227);
            this.sim.Name = "sim";
            this.sim.Size = new System.Drawing.Size(151, 58);
            this.sim.TabIndex = 3;
            this.sim.Text = "Sim";
            this.sim.UseVisualStyleBackColor = true;
            this.sim.Click += new System.EventHandler(this.sim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Você possui a Farmácia Popular?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Farma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(358, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nao);
            this.Controls.Add(this.sim);
            this.Name = "Farma";
            this.Text = "Farma";
            this.Load += new System.EventHandler(this.Farma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nao;
        private System.Windows.Forms.Button sim;
        private System.Windows.Forms.Label label1;
    }
}