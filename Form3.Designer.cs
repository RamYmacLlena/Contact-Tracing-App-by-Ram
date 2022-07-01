namespace Contact_Tracing_App
{
    partial class RecordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsForm));
            this.RecordsDataGrid = new System.Windows.Forms.DataGridView();
            this.PersonalDataRecords = new System.Windows.Forms.Label();
            this.Fromlbl = new System.Windows.Forms.Label();
            this.Tolbl = new System.Windows.Forms.Label();
            this.Filterbtn = new System.Windows.Forms.Button();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.DTP2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordsDataGrid
            // 
            this.RecordsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsDataGrid.Location = new System.Drawing.Point(12, 49);
            this.RecordsDataGrid.Name = "RecordsDataGrid";
            this.RecordsDataGrid.RowHeadersWidth = 51;
            this.RecordsDataGrid.RowTemplate.Height = 29;
            this.RecordsDataGrid.Size = new System.Drawing.Size(1382, 482);
            this.RecordsDataGrid.TabIndex = 0;
            this.RecordsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordsDataGrid_CellContentClick);
            // 
            // PersonalDataRecords
            // 
            this.PersonalDataRecords.AutoSize = true;
            this.PersonalDataRecords.BackColor = System.Drawing.Color.Transparent;
            this.PersonalDataRecords.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonalDataRecords.Location = new System.Drawing.Point(12, 9);
            this.PersonalDataRecords.Name = "PersonalDataRecords";
            this.PersonalDataRecords.Size = new System.Drawing.Size(283, 26);
            this.PersonalDataRecords.TabIndex = 1;
            this.PersonalDataRecords.Text = "Personal Data Records";
            // 
            // Fromlbl
            // 
            this.Fromlbl.AutoSize = true;
            this.Fromlbl.BackColor = System.Drawing.Color.Transparent;
            this.Fromlbl.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fromlbl.Location = new System.Drawing.Point(883, 15);
            this.Fromlbl.Name = "Fromlbl";
            this.Fromlbl.Size = new System.Drawing.Size(74, 23);
            this.Fromlbl.TabIndex = 2;
            this.Fromlbl.Text = "From : ";
            // 
            // Tolbl
            // 
            this.Tolbl.AutoSize = true;
            this.Tolbl.BackColor = System.Drawing.Color.Transparent;
            this.Tolbl.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tolbl.Location = new System.Drawing.Point(1106, 15);
            this.Tolbl.Name = "Tolbl";
            this.Tolbl.Size = new System.Drawing.Size(44, 23);
            this.Tolbl.TabIndex = 3;
            this.Tolbl.Text = "To :";
            // 
            // Filterbtn
            // 
            this.Filterbtn.BackColor = System.Drawing.Color.Transparent;
            this.Filterbtn.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Filterbtn.Location = new System.Drawing.Point(1300, 12);
            this.Filterbtn.Name = "Filterbtn";
            this.Filterbtn.Size = new System.Drawing.Size(94, 29);
            this.Filterbtn.TabIndex = 4;
            this.Filterbtn.Text = "FILTER";
            this.Filterbtn.UseVisualStyleBackColor = false;
            this.Filterbtn.Click += new System.EventHandler(this.Filterbtn_Click);
            // 
            // DTP1
            // 
            this.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP1.Location = new System.Drawing.Point(963, 13);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(127, 27);
            this.DTP1.TabIndex = 5;
            // 
            // DTP2
            // 
            this.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP2.Location = new System.Drawing.Point(1156, 13);
            this.DTP2.Name = "DTP2";
            this.DTP2.Size = new System.Drawing.Size(127, 27);
            this.DTP2.TabIndex = 6;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1406, 543);
            this.Controls.Add(this.DTP2);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.Filterbtn);
            this.Controls.Add(this.Tolbl);
            this.Controls.Add(this.Fromlbl);
            this.Controls.Add(this.PersonalDataRecords);
            this.Controls.Add(this.RecordsDataGrid);
            this.DoubleBuffered = true;
            this.Name = "RecordsForm";
            this.Text = "Data Records ";
            this.Load += new System.EventHandler(this.RecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView RecordsDataGrid;
        private Label PersonalDataRecords;
        private Label Fromlbl;
        private Label Tolbl;
        private Button Filterbtn;
        private DateTimePicker DTP1;
        private DateTimePicker DTP2;
    }
}