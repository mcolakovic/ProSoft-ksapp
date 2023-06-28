
namespace KorisnickiInterfejs
{
    partial class FrmKlijent
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPozicija = new System.Windows.Forms.TextBox();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izbaci element sa pozicije:";
            // 
            // txtPozicija
            // 
            this.txtPozicija.Location = new System.Drawing.Point(224, 34);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.Size = new System.Drawing.Size(100, 22);
            this.txtPozicija.TabIndex = 1;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Location = new System.Drawing.Point(39, 71);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(169, 31);
            this.btnIzbaci.TabIndex = 2;
            this.btnIzbaci.Text = "Izbaci element";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            this.btnIzbaci.Click += new System.EventHandler(this.btnIzbaci_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Poruka servera:";
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(39, 149);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(471, 22);
            this.txtPoruka.TabIndex = 4;
            // 
            // FrmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 218);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.txtPozicija);
            this.Controls.Add(this.label1);
            this.Name = "FrmKlijent";
            this.Text = "Klijent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPozicija;
        private System.Windows.Forms.Button btnIzbaci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoruka;
    }
}