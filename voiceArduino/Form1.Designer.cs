namespace voiceArduino
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(36, 40);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(219, 31);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Enable Voice Recognition";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(333, 40);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(211, 31);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "Disable Voice Recognition";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(56, 114);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(605, 198);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.Text = "-Status-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

