using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AaronRash_CPT_206_Lab_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void stateInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateInfoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateInfoDataSet.StateInfo' table. You can move, or remove it, as needed.
            this.stateInfoTableAdapter.Fill(this.stateInfoDataSet.StateInfo);

        }

        //Select button (for selecting state & opening new form)
        private void bSelectState_Click(object sender, EventArgs e)
        {
            string selectedState = cbStateList.SelectedItem.ToString(); //Save the selected state as 'selectedState'

            StateForm FormState = new StateForm(selectedState); //Pass the selected state to a new form

            FormState.ShowDialog(); //Show new form
        }

        //Search Button
        private void bSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
