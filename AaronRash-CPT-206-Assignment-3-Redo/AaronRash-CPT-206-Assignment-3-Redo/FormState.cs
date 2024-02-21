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
    public partial class FormState : Form
    {
        private string state; //Variable to be used by methods

        public FormState(string selectedState)
        {
            InitializeComponent();
            state = selectedState; //Set passed variable from FormMain (selectedState) to class variable (state)
        }

        //On form load
        private void FormState_Load(object sender, EventArgs e)
        {
            stateInfoTableAdapter.FillBy(stateInfoDataSet.StateInfo, state); //Fillby is a query that returns only the row of the selected state
        }


        //Save button
        private void stateInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateInfoDataSet);
            //This is where i would put an update query.. if i knew how
        }

        //Exit Button
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
