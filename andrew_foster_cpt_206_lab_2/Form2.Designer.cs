
namespace andrew_foster_cpt_206_lab_2
{
    partial class searchForm
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
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInfoDataSet1 = new andrew_foster_cpt_206_lab_2.StateInfoDataSet1();
            this.statesTableAdapter = new andrew_foster_cpt_206_lab_2.StateInfoDataSet1TableAdapters.StatesTableAdapter();
            this.closeButton = new System.Windows.Forms.Button();
            this.iTJobsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.stateInfoDataSet1;
            this.statesBindingSource.CurrentChanged += new System.EventHandler(this.statesBindingSource_CurrentChanged);
            // 
            // stateInfoDataSet1
            // 
            this.stateInfoDataSet1.DataSetName = "StateInfoDataSet1";
            this.stateInfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(197, 193);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 40);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // iTJobsDataGridViewTextBoxColumn
            // 
            this.iTJobsDataGridViewTextBoxColumn.DataPropertyName = "IT Jobs";
            this.iTJobsDataGridViewTextBoxColumn.HeaderText = "IT Jobs";
            this.iTJobsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iTJobsDataGridViewTextBoxColumn.Name = "iTJobsDataGridViewTextBoxColumn";
            this.iTJobsDataGridViewTextBoxColumn.Width = 83;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "income";
            this.incomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.Width = 82;
            // 
            // capitolDataGridViewTextBoxColumn
            // 
            this.capitolDataGridViewTextBoxColumn.DataPropertyName = "capitol";
            this.capitolDataGridViewTextBoxColumn.HeaderText = "capitol";
            this.capitolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capitolDataGridViewTextBoxColumn.Name = "capitolDataGridViewTextBoxColumn";
            this.capitolDataGridViewTextBoxColumn.Width = 78;
            // 
            // thirdCityDataGridViewTextBoxColumn
            // 
            this.thirdCityDataGridViewTextBoxColumn.DataPropertyName = "third city";
            this.thirdCityDataGridViewTextBoxColumn.HeaderText = "third city";
            this.thirdCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thirdCityDataGridViewTextBoxColumn.Name = "thirdCityDataGridViewTextBoxColumn";
            this.thirdCityDataGridViewTextBoxColumn.Width = 90;
            // 
            // secondCityDataGridViewTextBoxColumn
            // 
            this.secondCityDataGridViewTextBoxColumn.DataPropertyName = "second city";
            this.secondCityDataGridViewTextBoxColumn.HeaderText = "second city";
            this.secondCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.secondCityDataGridViewTextBoxColumn.Name = "secondCityDataGridViewTextBoxColumn";
            this.secondCityDataGridViewTextBoxColumn.Width = 108;
            // 
            // firstCityDataGridViewTextBoxColumn
            // 
            this.firstCityDataGridViewTextBoxColumn.DataPropertyName = "first city";
            this.firstCityDataGridViewTextBoxColumn.HeaderText = "first city";
            this.firstCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstCityDataGridViewTextBoxColumn.Name = "firstCityDataGridViewTextBoxColumn";
            this.firstCityDataGridViewTextBoxColumn.Width = 85;
            // 
            // colorsDataGridViewTextBoxColumn
            // 
            this.colorsDataGridViewTextBoxColumn.DataPropertyName = "colors";
            this.colorsDataGridViewTextBoxColumn.HeaderText = "colors";
            this.colorsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorsDataGridViewTextBoxColumn.Name = "colorsDataGridViewTextBoxColumn";
            this.colorsDataGridViewTextBoxColumn.Width = 75;
            // 
            // birdDataGridViewTextBoxColumn
            // 
            this.birdDataGridViewTextBoxColumn.DataPropertyName = "bird";
            this.birdDataGridViewTextBoxColumn.HeaderText = "bird";
            this.birdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birdDataGridViewTextBoxColumn.Name = "birdDataGridViewTextBoxColumn";
            this.birdDataGridViewTextBoxColumn.Width = 61;
            // 
            // flowerDataGridViewTextBoxColumn
            // 
            this.flowerDataGridViewTextBoxColumn.DataPropertyName = "flower";
            this.flowerDataGridViewTextBoxColumn.HeaderText = "flower";
            this.flowerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flowerDataGridViewTextBoxColumn.Name = "flowerDataGridViewTextBoxColumn";
            this.flowerDataGridViewTextBoxColumn.Width = 74;
            // 
            // flagDataGridViewTextBoxColumn
            // 
            this.flagDataGridViewTextBoxColumn.DataPropertyName = "flag";
            this.flagDataGridViewTextBoxColumn.HeaderText = "flag";
            this.flagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flagDataGridViewTextBoxColumn.Name = "flagDataGridViewTextBoxColumn";
            this.flagDataGridViewTextBoxColumn.Width = 60;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "population";
            this.populationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.Width = 103;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 72;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 68;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.flagDataGridViewTextBoxColumn,
            this.flowerDataGridViewTextBoxColumn,
            this.birdDataGridViewTextBoxColumn,
            this.colorsDataGridViewTextBoxColumn,
            this.firstCityDataGridViewTextBoxColumn,
            this.secondCityDataGridViewTextBoxColumn,
            this.thirdCityDataGridViewTextBoxColumn,
            this.capitolDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.iTJobsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 249);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "searchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Results";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StateInfoDataSet1 stateInfoDataSet1;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private StateInfoDataSet1TableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTJobsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}