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
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        // needed variables for searches
        public static bool name, pop, flag, flower, bird, colors, first, second, third, capitol, income, jobs, all, desc, asc;

        public static String descriptionSearch;

        private void statesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.statesTableAdapter.Update(this.stateInfoDataSet1);
            //connect database to the program
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // transfer information from Form1 to searchForm
            all = Form1.all;
            name = Form1.name;
            pop = Form1.pop;
            flag = Form1.flag;
            flower = Form1.flower;
            bird = Form1.bird;
            colors = Form1.colors;
            first = Form1.first;
            second = Form1.second;
            third = Form1.third;
            capitol = Form1.capitol;
            income = Form1.income;
            jobs = Form1.income;
            asc = Form1.asc;
            desc = Form1.desc;
            descriptionSearch = Form1.descriptionSearch;

            DataClasses1DataContext db = new DataClasses1DataContext();
            // TODO: This line of code loads data into the 'stateInfoDataSet1.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.stateInfoDataSet1.States);

            // all is false if an individual record is wanted to be displayed
            if (all == false)
            {
                var results = from States in db.States
                              where States.state1 == Form1.stateSelect
                              select States;

                dataGridView1.DataSource = results.ToList();
            }

            // the following statements are for sorting searches to display entire table contents
            else if (name == true)
            {
                if (asc == true) 
                {
                    var results = from States in db.States
                                  orderby States.state1
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
                else
                {
                    var results = from States in db.States
                                  orderby States.state1 descending
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
                
            }
            else if (pop == true)
            {
                if (asc == true)
                {
                    var results = from States in db.States
                                  orderby States.population
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
                else
                {
                    var results = from States in db.States
                                  orderby States.population descending
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }

            }
            else if (flag == true)
            {
                var results = from States in db.States
                              where States.flag.Contains(Form1.descriptionSearch)
                              select States;
                dataGridView1.DataSource = results.ToList();
            }
            else if (flower == true)
            {
                var results = from States in db.States
                              where States.flower.Contains(Form1.descriptionSearch)
                              select States;
                dataGridView1.DataSource = results.ToList();
            }
            else if (bird == true)
            {
                var results = from States in db.States
                              where States.bird.Contains(Form1.descriptionSearch)
                              select States;
                dataGridView1.DataSource = results.ToList();
            }
            else if (colors == true)
            {
                var results = from States in db.States
                              where States.colors.Contains(Form1.descriptionSearch)
                              select States;
                dataGridView1.DataSource = results.ToList();
            }
            else if (first == true)
            {
                if (asc == true)
                {
                    var results = from States in db.States
                                  orderby States.first_city
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
                else
                {
                    var results = from States in db.States
                                  orderby States.first_city descending
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
            }
            else if (second == true)
            {
                if (asc == true)
                {
                    var results = from States in db.States
                                  orderby States.second_city
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
                else
                {
                    var results = from States in db.States
                                  orderby States.second_city descending
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
            }
            else if (third == true)
            {
                if (asc == true)
                {
                    var results = from States in db.States
                                  orderby States.third_city
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
                else
                {
                    var results = from States in db.States
                                  orderby States.third_city descending
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
            }
            else if (capitol == true)
            {
                if (asc == true)
                {
                    var results = from States in db.States
                                  orderby States.capitol
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
                else
                {
                    var results = from States in db.States
                                  orderby States.capitol descending
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
            }
            else if (income == true)
            {
                if (asc == true)
                {
                    var results = from States in db.States
                                  orderby States.income
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
                else
                {
                    var results = from States in db.States
                                  orderby States.income descending
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
            }
            else if (jobs == true)
            {
                if (asc == true)
                {
                    var results = from States in db.States
                                  orderby States.it_jobs
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
                else
                {
                    var results = from States in db.States
                                  orderby States.it_jobs descending
                                  select States;
                    dataGridView1.DataSource = results.ToList();
                }
            }
        }

        // this form is just for viewing results, so all the user can do is look and close
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
