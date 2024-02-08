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
    public partial class StateForm : Form
    {
        public StateForm(string selectedState)
        {
            InitializeComponent();
        }

        private void StateInfoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.stateInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateInfoDataSet);

        }

        private void StateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateInfoDataSet.StateInfo' table. You can move, or remove it, as needed.
            this.stateInfoTableAdapter.Fill(this.stateInfoDataSet.StateInfo);

        }
    }
}
