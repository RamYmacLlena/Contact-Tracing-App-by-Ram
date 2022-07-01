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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_Code));
            this.CameraComboBoxDevice = new System.Windows.Forms.ComboBox();
            this.camerapicbox = new System.Windows.Forms.PictureBox();
            this.Scanbtn = new System.Windows.Forms.Button();
            this.cameralbl = new System.Windows.Forms.Label();
            this.timerscan = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.QRscannedinfoDatagridview = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.camerapicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRscannedinfoDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraComboBoxDevice
            // 
            this.CameraComboBoxDevice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CameraComboBoxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CameraComboBoxDevice.FormattingEnabled = true;
            this.CameraComboBoxDevice.Location = new System.Drawing.Point(110, 9);
            this.CameraComboBoxDevice.Name = "CameraComboBoxDevice";
            this.CameraComboBoxDevice.Size = new System.Drawing.Size(319, 28);
            this.CameraComboBoxDevice.TabIndex = 0;
            // 
            // camerapicbox
            // 
            this.camerapicbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.camerapicbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.camerapicbox.Location = new System.Drawing.Point(12, 46);
            this.camerapicbox.Name = "camerapicbox";
            this.camerapicbox.Size = new System.Drawing.Size(491, 341);
            this.camerapicbox.TabIndex = 1;
            this.camerapicbox.TabStop = false;
            // 
            // Scanbtn
            // 
            this.Scanbtn.BackColor = System.Drawing.Color.Aqua;
            this.Scanbtn.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Scanbtn.Location = new System.Drawing.Point(178, 405);
            this.Scanbtn.Name = "Scanbtn";
            this.Scanbtn.Size = new System.Drawing.Size(147, 44);
            this.Scanbtn.TabIndex = 2;
            this.Scanbtn.Text = "SCAN";
            this.Scanbtn.UseVisualStyleBackColor = false;
            this.Scanbtn.Click += new System.EventHandler(this.Scanbtn_Click);
            // 
            // cameralbl
            // 
            this.cameralbl.AutoSize = true;
            this.cameralbl.BackColor = System.Drawing.Color.Transparent;
            this.cameralbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameralbl.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cameralbl.Location = new System.Drawing.Point(12, 12);
            this.cameralbl.Name = "cameralbl";
            this.cameralbl.Size = new System.Drawing.Size(92, 25);
            this.cameralbl.TabIndex = 3;
            this.cameralbl.Text = "Camera :";
            // 
            // timerscan
            // 
            this.timerscan.Tick += new System.EventHandler(this.TimerWebcam);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(528, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "QR Data Info :";
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.Aqua;
            this.submitbtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitbtn.Location = new System.Drawing.Point(589, 343);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(166, 44);
            this.submitbtn.TabIndex = 6;
            this.submitbtn.Text = "Submit Data";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // QRscannedinfoDatagridview
            // 
            this.QRscannedinfoDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QRscannedinfoDatagridview.Location = new System.Drawing.Point(528, 73);
            this.QRscannedinfoDatagridview.Name = "QRscannedinfoDatagridview";
            this.QRscannedinfoDatagridview.RowHeadersWidth = 51;
            this.QRscannedinfoDatagridview.RowTemplate.Height = 29;
            this.QRscannedinfoDatagridview.Size = new System.Drawing.Size(316, 264);
            this.QRscannedinfoDatagridview.TabIndex = 7;
            this.QRscannedinfoDatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QRscannedinfoDatagridview_CellContentClick);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Aqua;
            this.backbtn.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backbtn.Location = new System.Drawing.Point(608, 405);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(129, 44);
            this.backbtn.TabIndex = 8;
            this.backbtn.Text = "BACK";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // QR_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 461);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.QRscannedinfoDatagridview);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cameralbl);
            this.Controls.Add(this.Scanbtn);
            this.Controls.Add(this.camerapicbox);
            this.Controls.Add(this.CameraComboBoxDevice);
            this.Name = "QR_Code";
            this.Text = "QR_Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
            this.Load += new System.EventHandler(this.QR_Code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camerapicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRscannedinfoDatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CameraComboBoxDevice;
        private PictureBox camerapicbox;
        private Button Scanbtn;
        private Label cameralbl;
        private System.Windows.Forms.Timer timerscan;
        private Label label1;
        private Button submitbtn;
        private DataGridView QRscannedinfoDatagridview;
        private Button backbtn;
    }
}