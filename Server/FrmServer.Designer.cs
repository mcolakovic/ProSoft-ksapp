
namespace Server
{
    partial class FrmServer
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
            this.lblServer = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBrojevi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrojevi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(43, 31);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(139, 17);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server nije pokrenut!";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Location = new System.Drawing.Point(285, 31);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(0, 17);
            this.lblVrijeme.TabIndex = 1;
            this.lblVrijeme.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(46, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Pokreni server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(117, 107);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 17);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sada je:";
            this.label4.Visible = false;
            // 
            // dgvBrojevi
            // 
            this.dgvBrojevi.AllowUserToAddRows = false;
            this.dgvBrojevi.AllowUserToDeleteRows = false;
            this.dgvBrojevi.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvBrojevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrojevi.Enabled = false;
            this.dgvBrojevi.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgvBrojevi.Location = new System.Drawing.Point(45, 149);
            this.dgvBrojevi.Name = "dgvBrojevi";
            this.dgvBrojevi.ReadOnly = true;
            this.dgvBrojevi.RowHeadersVisible = false;
            this.dgvBrojevi.RowHeadersWidth = 51;
            this.dgvBrojevi.RowTemplate.Height = 24;
            this.dgvBrojevi.Size = new System.Drawing.Size(598, 90);
            this.dgvBrojevi.TabIndex = 5;
            this.dgvBrojevi.Visible = false;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 282);
            this.Controls.Add(this.dgvBrojevi);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.lblServer);
            this.Name = "FrmServer";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrojevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.DataGridView dgvBrojevi;
    }
}

