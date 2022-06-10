namespace Contact_Tracing_App
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.personalinfolbl = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox
            // 
            this.imgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgBox.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.blank_profile_picture_973460_6401;
            this.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgBox.Location = new System.Drawing.Point(70, 20);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(238, 202);
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            // 
            // personalinfolbl
            // 
            this.personalinfolbl.AutoSize = true;
            this.personalinfolbl.BackColor = System.Drawing.Color.Transparent;
            this.personalinfolbl.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personalinfolbl.Location = new System.Drawing.Point(34, 244);
            this.personalinfolbl.Name = "personalinfolbl";
            this.personalinfolbl.Size = new System.Drawing.Size(305, 29);
            this.personalinfolbl.TabIndex = 1;
            this.personalinfolbl.Text = "Personal Information";
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startbtn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startbtn.Location = new System.Drawing.Point(102, 306);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(173, 63);
            this.startbtn.TabIndex = 2;
            this.startbtn.Text = "Let\'s Start Contact Tracing!";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitbtn.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitbtn.Location = new System.Drawing.Point(121, 395);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(132, 55);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Not Now";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 496);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.personalinfolbl);
            this.Controls.Add(this.imgBox);
            this.Name = "StartForm";
            this.Text = "COVID 19 - Start Contact Tracing";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox imgBox;
        private Label personalinfolbl;
        private Button startbtn;
        private Button exitbtn;
    }
}