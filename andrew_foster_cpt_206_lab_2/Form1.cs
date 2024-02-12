using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andrew_foster_cpt_206_lab_2
{
    /* Andrew Foster (deucemaccoy)
     * CPT-206
     * Lab 2
     */

    public partial class Form1 : Form
    {
        // array to fill in state names for combo boxes
        public String[] fill = new String[50]
        {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"
        };

        // array to fill in attribute combo boxes for searching
        public String[] columns = new string[12]
        {
            "State Name",
            "Flag",
            "Flower",
            "Bird",
            "Colors",
            "Population",
            "Highest Population",
            "2nd Highest Population",
            "3rd Highest Population",
            "Capitol",
            "Median Income",
            "IT Jobs %"
        };

        // method to reset boolean values
        private void Reset()
        {
            name = false;
            pop = false;
            flag = false;
            flower = false;
            bird = false;
            colors = false;
            first = false;
            second = false;
            third = false;
            capitol = false;
            income = false;
            it = false;
        }

        // boolean values to manipulate table properties
        public static bool name = false, pop = false, flag = false, flower = false, bird = false, colors = false, first = false, second = false, third = false, capitol = false, income = false, it = false, all = false, asc = true, desc = false;

        private void statesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.statesTableAdapter.Update(this.stateInfoDataSet1);
            //connect database to the program
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            Reset();
            
            // linq classes
            DataClasses1DataContext db = new DataClasses1DataContext();

            // variables for parsing
            int updatePopOrIncome;
            double updateJobs;

            // update value per user submission
            State change = db.States.FirstOrDefault(State => State.state1 == updateComboBox.SelectedIndex + 1);
            if (change != null)
            {
                if (columnComboBox.SelectedIndex == 0) { change.name = updateTextBox.Text; }
                if (columnComboBox.SelectedIndex == 1) { change.flag = updateTextBox.Text; }
                if (columnComboBox.SelectedIndex == 2) { change.flower = updateTextBox.Text; }
                if (columnComboBox.SelectedIndex == 3) { change.bird = updateTextBox.Text; }
                if (columnComboBox.SelectedIndex == 4) { change.colors = updateTextBox.Text; }
                if (columnComboBox.SelectedIndex == 5) 
                {
                    int.TryParse(updateTextBox.Text, out updatePopOrIncome);
                    change.population = updatePopOrIncome;
                }
                if (columnComboBox.SelectedIndex == 6) { change.first_city = updateTextBox.Text; }
                if (columnComboBox.SelectedIndex == 7) { change.second_city = updateTextBox.Text; }
                if (columnComboBox.SelectedIndex == 8) { change.third_city = updateTextBox.Text; }
                if (columnComboBox.SelectedIndex == 9) { change.capitol = updateTextBox.Text; }
                if (columnComboBox.SelectedIndex == 10) 
                {
                    int.TryParse(updateTextBox.Text, out updatePopOrIncome);
                    change.income = updatePopOrIncome;
                }
                if (columnComboBox.SelectedIndex == 11)
                {
                    double.TryParse(updateTextBox.Text, out updateJobs);
                    change.it_jobs = updateJobs;
                }

            // submit changes and bring up changed record so user can verify information was updated properly
            db.SubmitChanges();
            Reset();
            stateComboBox.SelectedIndex = updateComboBox.SelectedIndex;
            searchForm search = new searchForm();
            search.ShowDialog();
            }

            
        }

        public static String descriptionSearch;

        private void descButton_CheckedChanged(object sender, EventArgs e)
        {
            asc = false;
            desc = true;
        }

        private void ascRadio_CheckedChanged(object sender, EventArgs e)
        {
            desc = false;
            asc = true;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            // when sorting, the user wants to look at the entire table, not just an individual record
            all = true;

            //resets boolean values
            Reset();

            // error message if search field is left blank
            if (sortComboBox.SelectedIndex > 1 && sortComboBox.SelectedIndex < 9 && desciptionSearchText.Text.Length < 1) { MessageBox.Show("You must enter a search paramter to search for text within the " + sortComboBox.SelectedItem + " data field."); }
            else
            {
                descriptionSearch = desciptionSearchText.Text;
                searchForm Search = new searchForm();
                Search.ShowDialog();
            }
        }

        //needed variable for individual state searches
        public static int stateSelect;

        public Form1()
        {
            InitializeComponent();
        }

        //fill in combo box items
        private void Form1_Load(object sender, EventArgs e)
        {
            stateComboBox.Items.AddRange(fill);
            updateComboBox.Items.AddRange(fill);
            columnComboBox.Items.AddRange(columns);
            sortComboBox.Items.AddRange(columns);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
            // clears all checks, text fields, and dropdown menus
        {
            stateComboBox.SelectedIndex = -1;
            updateComboBox.SelectedIndex = -1;
            columnComboBox.SelectedIndex = -1;
            sortComboBox.SelectedIndex = -1;
            stateSelect = 0;
            Reset();
            all = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // error message if no state is selected before searching
            if (stateComboBox.SelectedIndex < 0) { MessageBox.Show("You must select a state from the dropdown menu to perform a search."); }
            else 
            {
                Reset();
                // tells the search form to only select one record
                all = false;
                // select proper state
                stateSelect = stateComboBox.SelectedIndex + 1;
                searchForm Search = new searchForm();
                Search.ShowDialog();
            }
        }
    }
}
