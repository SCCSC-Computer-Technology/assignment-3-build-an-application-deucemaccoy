
namespace andrew_foster_cpt_206_lab_2
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
            this.stateLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInfoDataSet1 = new andrew_foster_cpt_206_lab_2.StateInfoDataSet1();
            this.statesTableAdapter = new andrew_foster_cpt_206_lab_2.StateInfoDataSet1TableAdapters.StatesTableAdapter();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.updateBox = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.infoLab = new System.Windows.Forms.Label();
            this.updateTextBox = new System.Windows.Forms.TextBox();
            this.columnComboBox = new System.Windows.Forms.ComboBox();
            this.columnUpdateLabel = new System.Windows.Forms.Label();
            this.stateUpdateLabel = new System.Windows.Forms.Label();
            this.updateComboBox = new System.Windows.Forms.ComboBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.sortBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.desciptionSearchText = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.descButton = new System.Windows.Forms.RadioButton();
            this.ascRadio = new System.Windows.Forms.RadioButton();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet1)).BeginInit();
            this.searchBox.SuspendLayout();
            this.updateBox.SuspendLayout();
            this.sortBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(11, 46);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(53, 20);
            this.stateLabel.TabIndex = 1;
            this.stateLabel.Text = "State:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(70, 108);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 25);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.stateInfoDataSet1;
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
            // clearAllButton
            // 
            this.clearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.Location = new System.Drawing.Point(294, 232);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(100, 35);
            this.clearAllButton.TabIndex = 4;
            this.clearAllButton.Text = "Clear &All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(624, 232);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 35);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(70, 46);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(75, 24);
            this.stateComboBox.TabIndex = 6;
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.stateComboBox);
            this.searchBox.Controls.Add(this.searchButton);
            this.searchBox.Controls.Add(this.stateLabel);
            this.searchBox.Location = new System.Drawing.Point(20, 64);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(190, 146);
            this.searchBox.TabIndex = 7;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Individual State Details";
            // 
            // updateBox
            // 
            this.updateBox.Controls.Add(this.updateButton);
            this.updateBox.Controls.Add(this.infoLab);
            this.updateBox.Controls.Add(this.updateTextBox);
            this.updateBox.Controls.Add(this.columnComboBox);
            this.updateBox.Controls.Add(this.columnUpdateLabel);
            this.updateBox.Controls.Add(this.stateUpdateLabel);
            this.updateBox.Controls.Add(this.updateComboBox);
            this.updateBox.Location = new System.Drawing.Point(614, 64);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(395, 146);
            this.updateBox.TabIndex = 8;
            this.updateBox.TabStop = false;
            this.updateBox.Text = "Update Data";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(150, 108);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 25);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // infoLab
            // 
            this.infoLab.AutoSize = true;
            this.infoLab.Location = new System.Drawing.Point(29, 68);
            this.infoLab.Name = "infoLab";
            this.infoLab.Size = new System.Drawing.Size(102, 34);
            this.infoLab.TabIndex = 5;
            this.infoLab.Text = "Information\r\nto be Updated:\r\n";
            this.infoLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateTextBox
            // 
            this.updateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTextBox.Location = new System.Drawing.Point(137, 74);
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(236, 27);
            this.updateTextBox.TabIndex = 4;
            // 
            // columnComboBox
            // 
            this.columnComboBox.FormattingEnabled = true;
            this.columnComboBox.Location = new System.Drawing.Point(229, 36);
            this.columnComboBox.Name = "columnComboBox";
            this.columnComboBox.Size = new System.Drawing.Size(157, 24);
            this.columnComboBox.TabIndex = 3;
            // 
            // columnUpdateLabel
            // 
            this.columnUpdateLabel.AutoSize = true;
            this.columnUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnUpdateLabel.Location = new System.Drawing.Point(146, 36);
            this.columnUpdateLabel.Name = "columnUpdateLabel";
            this.columnUpdateLabel.Size = new System.Drawing.Size(77, 20);
            this.columnUpdateLabel.TabIndex = 2;
            this.columnUpdateLabel.Text = "Attribute:";
            // 
            // stateUpdateLabel
            // 
            this.stateUpdateLabel.AutoSize = true;
            this.stateUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateUpdateLabel.Location = new System.Drawing.Point(6, 36);
            this.stateUpdateLabel.Name = "stateUpdateLabel";
            this.stateUpdateLabel.Size = new System.Drawing.Size(53, 20);
            this.stateUpdateLabel.TabIndex = 1;
            this.stateUpdateLabel.Text = "State:";
            // 
            // updateComboBox
            // 
            this.updateComboBox.FormattingEnabled = true;
            this.updateComboBox.Location = new System.Drawing.Point(65, 36);
            this.updateComboBox.Name = "updateComboBox";
            this.updateComboBox.Size = new System.Drawing.Size(75, 24);
            this.updateComboBox.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(44, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(910, 44);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "The United States of America Information Repository";
            // 
            // sortBox
            // 
            this.sortBox.Controls.Add(this.descriptionLabel);
            this.sortBox.Controls.Add(this.desciptionSearchText);
            this.sortBox.Controls.Add(this.sortButton);
            this.sortBox.Controls.Add(this.descButton);
            this.sortBox.Controls.Add(this.ascRadio);
            this.sortBox.Controls.Add(this.sortComboBox);
            this.sortBox.Location = new System.Drawing.Point(216, 64);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(392, 146);
            this.sortBox.TabIndex = 10;
            this.sortBox.TabStop = false;
            this.sortBox.Text = "Sort by Parameter";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(6, 56);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(104, 20);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Text Search:";
            // 
            // desciptionSearchText
            // 
            this.desciptionSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desciptionSearchText.Location = new System.Drawing.Point(116, 53);
            this.desciptionSearchText.Name = "desciptionSearchText";
            this.desciptionSearchText.Size = new System.Drawing.Size(235, 27);
            this.desciptionSearchText.TabIndex = 4;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(148, 108);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 25);
            this.sortButton.TabIndex = 3;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // descButton
            // 
            this.descButton.Location = new System.Drawing.Point(206, 81);
            this.descButton.Name = "descButton";
            this.descButton.Size = new System.Drawing.Size(145, 21);
            this.descButton.TabIndex = 2;
            this.descButton.Text = "Descending Order";
            this.descButton.UseVisualStyleBackColor = true;
            this.descButton.CheckedChanged += new System.EventHandler(this.descButton_CheckedChanged);
            // 
            // ascRadio
            // 
            this.ascRadio.AutoSize = true;
            this.ascRadio.Checked = true;
            this.ascRadio.Location = new System.Drawing.Point(36, 81);
            this.ascRadio.Name = "ascRadio";
            this.ascRadio.Size = new System.Drawing.Size(136, 21);
            this.ascRadio.TabIndex = 1;
            this.ascRadio.TabStop = true;
            this.ascRadio.Text = "Ascending Order";
            this.ascRadio.UseVisualStyleBackColor = true;
            this.ascRadio.CheckedChanged += new System.EventHandler(this.ascRadio_CheckedChanged);
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(36, 21);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(315, 24);
            this.sortComboBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 284);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.updateBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearAllButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Andrew Foster CPT-206 Lab 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet1)).EndInit();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            this.updateBox.ResumeLayout(false);
            this.updateBox.PerformLayout();
            this.sortBox.ResumeLayout(false);
            this.sortBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Button searchButton;
        private StateInfoDataSet1 stateInfoDataSet1;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private StateInfoDataSet1TableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.GroupBox updateBox;
        private System.Windows.Forms.TextBox updateTextBox;
        private System.Windows.Forms.ComboBox columnComboBox;
        private System.Windows.Forms.Label columnUpdateLabel;
        private System.Windows.Forms.Label stateUpdateLabel;
        private System.Windows.Forms.ComboBox updateComboBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox sortBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label infoLab;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.RadioButton descButton;
        private System.Windows.Forms.RadioButton ascRadio;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox desciptionSearchText;
    }
}

