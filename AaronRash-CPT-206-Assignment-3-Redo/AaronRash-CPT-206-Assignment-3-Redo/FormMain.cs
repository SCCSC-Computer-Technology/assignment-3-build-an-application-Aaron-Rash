using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AaronRash_CPT_206_Assignment_3_Redo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //On form load
        private void FormMain_Load(object sender, EventArgs e)
        {
            //Fill table with data
            this.stateInfoTableAdapter.Fill(this.stateInfoDataSet.StateInfo);

            //Had to manually set combobox data source to avoid errors
            cbStates.DataSource = stateInfoBindingSource;
            cbStates.DisplayMember = "State";
            cbStates.ValueMember = "State"; //Manually set data source value member. Setting value member on through designer was returning "System.Data.DataRowView"
        }

        //Select State Button (Open new form)
        private void bSelect_Click(object sender, EventArgs e)
        {

            string selectedState = cbStates.SelectedValue.ToString(); //Get selected value from drop down

            FormState formState = new FormState(selectedState); //Pass selected state to new form
            formState.ShowDialog(); //Show new form
        }
       
        //Search by Text
        private void bSearch_Click(object sender, EventArgs e)
        {
            int column = lbColumn.SelectedIndex; //Find the selected column

            //I made a LIKE query for each text column
            switch (column)
            {
                case 0: 
                    stateInfoTableAdapter.SearchState(stateInfoDataSet.StateInfo, tSearch.Text);
                    break;
                case 1: 
                    stateInfoTableAdapter.SearchFlag(stateInfoDataSet.StateInfo, tSearch.Text);
                    break;
                case 2: 
                    stateInfoTableAdapter.SearchFlower(stateInfoDataSet.StateInfo, tSearch.Text);
                    break;
                case 3: 
                    stateInfoTableAdapter.SearchBird(stateInfoDataSet.StateInfo, tSearch.Text);
                    break;
                case 4:
                    stateInfoTableAdapter.SearchColors(stateInfoDataSet.StateInfo, tSearch.Text);
                    break;
                case 5:
                    stateInfoTableAdapter.SearchCities(stateInfoDataSet.StateInfo, tSearch.Text);
                    break;
                case 6:
                    stateInfoTableAdapter.SearchCapitol(stateInfoDataSet.StateInfo, tSearch.Text);
                    break;
            }
        }

        //Search by number 
        private void bSearchNum_Click(object sender, EventArgs e)
        {
            //Make sure they select column & query
            if (lbQuery.SelectedItem == null || lbNumColumn.SelectedItem == null)
            {
                MessageBox.Show("Please select both a column and a query");
            }

            //Make sure the input is decimal
            decimal.TryParse(tMax.Text, out decimal max);
            decimal.TryParse(tNum.Text, out decimal num);

            //Find which column/query is selected
            int NumColumn = lbNumColumn.SelectedIndex;
            int query = lbQuery.SelectedIndex;
         
            /* I made 3 sql querys (less than, greater than, and between)
            * 
            * for the 3 number columns (population, income, and jobs)
            * 
            * this is probably very redundant, but i dont know sql well enough yet */
            
            switch (NumColumn)
            {
                case 0: //Population
                    switch (query)
                    {
                        case 0: //Greater
                            stateInfoTableAdapter.PopGreater(stateInfoDataSet.StateInfo, num); break;
                        case 1://Lesser
                            stateInfoTableAdapter.PopLess(stateInfoDataSet.StateInfo, num); break;
                        case 2://Between
                            stateInfoTableAdapter.PopBetween(stateInfoDataSet.StateInfo, num, max); break;
                    }
                    break;
                case 1: //Income
                    switch (query)
                    {
                        case 0: //Greater
                            stateInfoTableAdapter.IncomeGreater(stateInfoDataSet.StateInfo, num); break;
                        case 1://Lesser
                            stateInfoTableAdapter.IncomeLess(stateInfoDataSet.StateInfo, num); break;
                        case 2://Between
                            stateInfoTableAdapter.IncomeBetween(stateInfoDataSet.StateInfo, num, max); break;
                    }
                    break;
                case 2: //Jobs
                    switch (query)
                    {
                        case 0: //Greater
                            stateInfoTableAdapter.JobsGreater(stateInfoDataSet.StateInfo, num); break;
                        case 1://Lesser
                            stateInfoTableAdapter.JobsLess(stateInfoDataSet.StateInfo, num); break;
                        case 2://Between
                            stateInfoTableAdapter.JobsBetween(stateInfoDataSet.StateInfo, num, max); break;
                    }
                    break;
            }
        }

        //A method to show/hide a second textbox & label depending if they are using the "Between" query. I thought it made input cleaner.
        private void lbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbQuery.SelectedIndex == 2)
            {
                label1.Visible = true;
                label2.Visible = true;
                tMax.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                tMax.Visible= false;
            }
        }

        //Clear button
        private void bClear_Click(object sender, EventArgs e)
        {
            //Clears all texboxes, listboxes, and resets datagrid
            lbColumn.ClearSelected();
            lbQuery.ClearSelected();
            lbNumColumn.ClearSelected();
            tSearch.Clear();
            tNum.Clear();
            tMax.Clear();
            cbStates.SelectedItem = null;
            stateInfoTableAdapter.Fill(stateInfoDataSet.StateInfo);
        }        

        //Exit Button
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
