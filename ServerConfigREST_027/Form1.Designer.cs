namespace ServerConfigREST_027
{
    partial class Form1
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
            this.lbReady = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbReady
            // 
            this.lbReady.AutoSize = true;
            this.lbReady.BackColor = System.Drawing.Color.Red;
            this.lbReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReady.ForeColor = System.Drawing.SystemColors.Control;
            this.lbReady.Location = new System.Drawing.Point(696, 30);
            this.lbReady.Name = "lbReady";
            this.lbReady.Size = new System.Drawing.Size(62, 29);
            this.lbReady.TabIndex = 11;
            this.lbReady.Text = "OFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Server Status";
            // 
            // btnOFF
            // 
            this.btnOFF.Location = new System.Drawing.Point(416, 216);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(75, 23);
            this.btnOFF.TabIndex = 9;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click_1);
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(281, 216);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(75, 23);
            this.btnON.TabIndex = 8;
            this.btnON.Text = "ON";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click_1);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(245, 167);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(279, 17);
            this.lblMsg.TabIndex = 7;
            this.lblMsg.Text = "Tekan Tombol ON untuk meyalakan server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server REST Exercise";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbReady);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReady;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
    }
}

