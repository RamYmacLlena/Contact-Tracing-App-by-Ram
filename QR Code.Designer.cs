namespace Contact_Tracing_App
{
    partial class QR_Code
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
            this.CameraComboBoxDevice = new System.Windows.Forms.ComboBox();
            this.camerapicbox = new System.Windows.Forms.PictureBox();
            this.Scanbtn = new System.Windows.Forms.Button();
            this.cameralbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.camerapicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraComboBoxDevice
            // 
            this.CameraComboBoxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CameraComboBoxDevice.FormattingEnabled = true;
            this.CameraComboBoxDevice.Location = new System.Drawing.Point(261, 14);
            this.CameraComboBoxDevice.Name = "CameraComboBoxDevice";
            this.CameraComboBoxDevice.Size = new System.Drawing.Size(319, 28);
            this.CameraComboBoxDevice.TabIndex = 0;
            // 
            // camerapicbox
            // 
            this.camerapicbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.camerapicbox.Location = new System.Drawing.Point(163, 51);
            this.camerapicbox.Name = "camerapicbox";
            this.camerapicbox.Size = new System.Drawing.Size(491, 446);
            this.camerapicbox.TabIndex = 1;
            this.camerapicbox.TabStop = false;
            // 
            // Scanbtn
            // 
            this.Scanbtn.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Scanbtn.Location = new System.Drawing.Point(322, 503);
            this.Scanbtn.Name = "Scanbtn";
            this.Scanbtn.Size = new System.Drawing.Size(147, 44);
            this.Scanbtn.TabIndex = 2;
            this.Scanbtn.Text = "SCAN";
            this.Scanbtn.UseVisualStyleBackColor = true;
            this.Scanbtn.Click += new System.EventHandler(this.Scanbtn_Click);
            // 
            // cameralbl
            // 
            this.cameralbl.AutoSize = true;
            this.cameralbl.BackColor = System.Drawing.Color.Transparent;
            this.cameralbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameralbl.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cameralbl.Location = new System.Drawing.Point(163, 17);
            this.cameralbl.Name = "cameralbl";
            this.cameralbl.Size = new System.Drawing.Size(92, 25);
            this.cameralbl.TabIndex = 3;
            this.cameralbl.Text = "Camera :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerWebcam);
            // 
            // QR_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.cameralbl);
            this.Controls.Add(this.Scanbtn);
            this.Controls.Add(this.camerapicbox);
            this.Controls.Add(this.CameraComboBoxDevice);
            this.Name = "QR_Code";
            this.Text = "QR_Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
            this.Load += new System.EventHandler(this.QR_Code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camerapicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CameraComboBoxDevice;
        private PictureBox camerapicbox;
        private Button Scanbtn;
        private Label cameralbl;
        private System.Windows.Forms.Timer timer1;
    }
}