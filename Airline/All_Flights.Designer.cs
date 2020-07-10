namespace Airline
{
    partial class All_Flights
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.airlineDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDbDataSet = new Airline.AirlineDbDataSet();
            this.Fligths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(2)))), ((int)(((byte)(79)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 100);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fligths,
            this.Column1,
            this.Column2,
            this.Time,
            this.airline,
            this.Column3});
            this.dataGridView1.DataSource = this.airlineDbDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(968, 411);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // airlineDbDataSetBindingSource
            // 
            this.airlineDbDataSetBindingSource.DataSource = this.airlineDbDataSet;
            this.airlineDbDataSetBindingSource.Position = 0;
            // 
            // airlineDbDataSet
            // 
            this.airlineDbDataSet.DataSetName = "AirlineDbDataSet";
            this.airlineDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Fligths
            // 
            this.Fligths.DataPropertyName = "Sofia";
            dataGridViewCellStyle1.NullValue = "Sofia";
            this.Fligths.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fligths.HeaderText = "From";
            this.Fligths.MinimumWidth = 8;
            this.Fligths.Name = "Fligths";
            this.Fligths.ReadOnly = true;
            this.Fligths.Width = 150;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.NullValue = "Varna";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "To";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.NullValue = "15.07.2020";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Day";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Time
            // 
            dataGridViewCellStyle4.NullValue = "18:20 (CET)";
            this.Time.DefaultCellStyle = dataGridViewCellStyle4;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 8;
            this.Time.Name = "Time";
            this.Time.Width = 150;
            // 
            // airline
            // 
            dataGridViewCellStyle5.NullValue = "Lufthansa";
            this.airline.DefaultCellStyle = dataGridViewCellStyle5;
            this.airline.HeaderText = "Airline";
            this.airline.MinimumWidth = 8;
            this.airline.Name = "airline";
            this.airline.Width = 150;
            // 
            // Column3
            // 
            dataGridViewCellStyle6.NullValue = "Boeing 777";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column3.HeaderText = "Aircraft";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // All_Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 518);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "All_Flights";
            this.Text = "All_Flights";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource airlineDbDataSetBindingSource;
        private AirlineDbDataSet airlineDbDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fligths;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn airline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}