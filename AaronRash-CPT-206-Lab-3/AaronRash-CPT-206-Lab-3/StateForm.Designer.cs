namespace AaronRash_CPT_206_Lab_3
{
    partial class StateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateForm));
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label populationLabel;
            System.Windows.Forms.Label flag_DescriptionLabel;
            System.Windows.Forms.Label flowerLabel;
            System.Windows.Forms.Label birdLabel;
            System.Windows.Forms.Label colorsLabel;
            System.Windows.Forms.Label three_Largest_CitiesLabel;
            System.Windows.Forms.Label capitolLabel;
            System.Windows.Forms.Label median_IncomeLabel;
            System.Windows.Forms.Label number_of_Computer_Jobs_Offered__Indeed_Label;
            this.stateInfoDataSet = new AaronRash_CPT_206_Lab_3.StateInfoDataSet();
            this.stateInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInfoTableAdapter = new AaronRash_CPT_206_Lab_3.StateInfoDataSetTableAdapters.StateInfoTableAdapter();
            this.tableAdapterManager = new AaronRash_CPT_206_Lab_3.StateInfoDataSetTableAdapters.TableAdapterManager();
            this.stateInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.stateInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.flag_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.flowerTextBox = new System.Windows.Forms.TextBox();
            this.birdTextBox = new System.Windows.Forms.TextBox();
            this.colorsTextBox = new System.Windows.Forms.TextBox();
            this.three_Largest_CitiesTextBox = new System.Windows.Forms.TextBox();
            this.capitolTextBox = new System.Windows.Forms.TextBox();
            this.median_IncomeTextBox = new System.Windows.Forms.TextBox();
            this.number_of_Computer_Jobs_Offered__Indeed_TextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            stateLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            flag_DescriptionLabel = new System.Windows.Forms.Label();
            flowerLabel = new System.Windows.Forms.Label();
            birdLabel = new System.Windows.Forms.Label();
            colorsLabel = new System.Windows.Forms.Label();
            three_Largest_CitiesLabel = new System.Windows.Forms.Label();
            capitolLabel = new System.Windows.Forms.Label();
            median_IncomeLabel = new System.Windows.Forms.Label();
            number_of_Computer_Jobs_Offered__Indeed_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoBindingNavigator)).BeginInit();
            this.stateInfoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateInfoDataSet
            // 
            this.stateInfoDataSet.DataSetName = "StateInfoDataSet";
            this.stateInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateInfoBindingSource
            // 
            this.stateInfoBindingSource.DataMember = "StateInfo";
            this.stateInfoBindingSource.DataSource = this.stateInfoDataSet;
            // 
            // stateInfoTableAdapter
            // 
            this.stateInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StateInfoTableAdapter = this.stateInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AaronRash_CPT_206_Lab_3.StateInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stateInfoBindingNavigator
            // 
            this.stateInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stateInfoBindingNavigator.BindingSource = this.stateInfoBindingSource;
            this.stateInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stateInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stateInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.stateInfoBindingNavigatorSaveItem});
            this.stateInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stateInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stateInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stateInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stateInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stateInfoBindingNavigator.Name = "stateInfoBindingNavigator";
            this.stateInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stateInfoBindingNavigator.Size = new System.Drawing.Size(764, 25);
            this.stateInfoBindingNavigator.TabIndex = 0;
            this.stateInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // stateInfoBindingNavigatorSaveItem
            // 
            this.stateInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stateInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stateInfoBindingNavigatorSaveItem.Image")));
            this.stateInfoBindingNavigatorSaveItem.Name = "stateInfoBindingNavigatorSaveItem";
            this.stateInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stateInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.stateInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.StateInfoBindingNavigatorSaveItem_Click_1);
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(12, 63);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 1;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(230, 60);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(512, 20);
            this.stateTextBox.TabIndex = 2;
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(12, 89);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(60, 13);
            populationLabel.TabIndex = 3;
            populationLabel.Text = "Population:";
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(230, 86);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(512, 20);
            this.populationTextBox.TabIndex = 4;
            // 
            // flag_DescriptionLabel
            // 
            flag_DescriptionLabel.AutoSize = true;
            flag_DescriptionLabel.Location = new System.Drawing.Point(12, 115);
            flag_DescriptionLabel.Name = "flag_DescriptionLabel";
            flag_DescriptionLabel.Size = new System.Drawing.Size(86, 13);
            flag_DescriptionLabel.TabIndex = 5;
            flag_DescriptionLabel.Text = "Flag Description:";
            // 
            // flag_DescriptionTextBox
            // 
            this.flag_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoBindingSource, "Flag Description", true));
            this.flag_DescriptionTextBox.Location = new System.Drawing.Point(230, 112);
            this.flag_DescriptionTextBox.Multiline = true;
            this.flag_DescriptionTextBox.Name = "flag_DescriptionTextBox";
            this.flag_DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.flag_DescriptionTextBox.Size = new System.Drawing.Size(512, 124);
            this.flag_DescriptionTextBox.TabIndex = 6;
            // 
            // flowerLabel
            // 
            flowerLabel.AutoSize = true;
            flowerLabel.Location = new System.Drawing.Point(12, 245);
            flowerLabel.Name = "flowerLabel";
            flowerLabel.Size = new System.Drawing.Size(41, 13);
            flowerLabel.TabIndex = 7;
            flowerLabel.Text = "Flower:";
            // 
            // flowerTextBox
            // 
            this.flowerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoBindingSource, "Flower", true));
            this.flowerTextBox.Location = new System.Drawing.Point(230, 242);
            this.flowerTextBox.Name = "flowerTextBox";
            this.flowerTextBox.Size = new System.Drawing.Size(512, 20);
            this.flowerTextBox.TabIndex = 8;
            // 
            // birdLabel
            // 
            birdLabel.AutoSize = true;
            birdLabel.Location = new System.Drawing.Point(12, 271);
            birdLabel.Name = "birdLabel";
            birdLabel.Size = new System.Drawing.Size(28, 13);
            birdLabel.TabIndex = 9;
            birdLabel.Text = "Bird:";
            // 
            // birdTextBox
            // 
            this.birdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoBindingSource, "Bird", true));
            this.birdTextBox.Location = new System.Drawing.Point(230, 268);
            this.birdTextBox.Name = "birdTextBox";
            this.birdTextBox.Size = new System.Drawing.Size(512, 20);
            this.birdTextBox.TabIndex = 10;
            // 
            // colorsLabel
            // 
            colorsLabel.AutoSize = true;
            colorsLabel.Location = new System.Drawing.Point(12, 297);
            colorsLabel.Name = "colorsLabel";
            colorsLabel.Size = new System.Drawing.Size(39, 13);
            colorsLabel.TabIndex = 11;
            colorsLabel.Text = "Colors:";
            // 
            // colorsTextBox
            // 
            this.colorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoBindingSource, "Colors", true));
            this.colorsTextBox.Location = new System.Drawing.Point(230, 294);
            this.colorsTextBox.Name = "colorsTextBox";
            this.colorsTextBox.Size = new System.Drawing.Size(512, 20);
            this.colorsTextBox.TabIndex = 12;
            // 
            // three_Largest_CitiesLabel
            // 
            three_Largest_CitiesLabel.AutoSize = true;
            three_Largest_CitiesLabel.Location = new System.Drawing.Point(12, 323);
            three_Largest_CitiesLabel.Name = "three_Largest_CitiesLabel";
            three_Largest_CitiesLabel.Size = new System.Drawing.Size(104, 13);
            three_Largest_CitiesLabel.TabIndex = 13;
            three_Largest_CitiesLabel.Text = "Three Largest Cities:";
            // 
            // three_Largest_CitiesTextBox
            // 
            this.three_Largest_CitiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoBindingSource, "Three Largest Cities", true));
            this.three_Largest_CitiesTextBox.Location = new System.Drawing.Point(230, 320);
            this.three_Largest_CitiesTextBox.Name = "three_Largest_CitiesTextBox";
            this.three_Largest_CitiesTextBox.Size = new System.Drawing.Size(512, 20);
            this.three_Largest_CitiesTextBox.TabIndex = 14;
            // 
            // capitolLabel
            // 
            capitolLabel.AutoSize = true;
            capitolLabel.Location = new System.Drawing.Point(12, 349);
            capitolLabel.Name = "capitolLabel";
            capitolLabel.Size = new System.Drawing.Size(42, 13);
            capitolLabel.TabIndex = 15;
            capitolLabel.Text = "Capitol:";
            // 
            // capitolTextBox
            // 
            this.capitolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoBindingSource, "Capitol", true));
            this.capitolTextBox.Location = new System.Drawing.Point(230, 346);
            this.capitolTextBox.Name = "capitolTextBox";
            this.capitolTextBox.Size = new System.Drawing.Size(512, 20);
            this.capitolTextBox.TabIndex = 16;
            // 
            // median_IncomeLabel
            // 
            median_IncomeLabel.AutoSize = true;
            median_IncomeLabel.Location = new System.Drawing.Point(12, 375);
            median_IncomeLabel.Name = "median_IncomeLabel";
            median_IncomeLabel.Size = new System.Drawing.Size(83, 13);
            median_IncomeLabel.TabIndex = 17;
            median_IncomeLabel.Text = "Median Income:";
            // 
            // median_IncomeTextBox
            // 
            this.median_IncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoBindingSource, "Median Income", true));
            this.median_IncomeTextBox.Location = new System.Drawing.Point(230, 372);
            this.median_IncomeTextBox.Name = "median_IncomeTextBox";
            this.median_IncomeTextBox.Size = new System.Drawing.Size(512, 20);
            this.median_IncomeTextBox.TabIndex = 18;
            // 
            // number_of_Computer_Jobs_Offered__Indeed_Label
            // 
            number_of_Computer_Jobs_Offered__Indeed_Label.AutoSize = true;
            number_of_Computer_Jobs_Offered__Indeed_Label.Location = new System.Drawing.Point(12, 401);
            number_of_Computer_Jobs_Offered__Indeed_Label.Name = "number_of_Computer_Jobs_Offered__Indeed_Label";
            number_of_Computer_Jobs_Offered__Indeed_Label.Size = new System.Drawing.Size(212, 13);
            number_of_Computer_Jobs_Offered__Indeed_Label.TabIndex = 19;
            number_of_Computer_Jobs_Offered__Indeed_Label.Text = "Number of Computer Jobs Offered (Indeed):";
            // 
            // number_of_Computer_Jobs_Offered__Indeed_TextBox
            // 
            this.number_of_Computer_Jobs_Offered__Indeed_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoBindingSource, "Number of Computer Jobs Offered (Indeed)", true));
            this.number_of_Computer_Jobs_Offered__Indeed_TextBox.Location = new System.Drawing.Point(230, 398);
            this.number_of_Computer_Jobs_Offered__Indeed_TextBox.Name = "number_of_Computer_Jobs_Offered__Indeed_TextBox";
            this.number_of_Computer_Jobs_Offered__Indeed_TextBox.Size = new System.Drawing.Size(512, 20);
            this.number_of_Computer_Jobs_Offered__Indeed_TextBox.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // StateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(flag_DescriptionLabel);
            this.Controls.Add(this.flag_DescriptionTextBox);
            this.Controls.Add(flowerLabel);
            this.Controls.Add(this.flowerTextBox);
            this.Controls.Add(birdLabel);
            this.Controls.Add(this.birdTextBox);
            this.Controls.Add(colorsLabel);
            this.Controls.Add(this.colorsTextBox);
            this.Controls.Add(three_Largest_CitiesLabel);
            this.Controls.Add(this.three_Largest_CitiesTextBox);
            this.Controls.Add(capitolLabel);
            this.Controls.Add(this.capitolTextBox);
            this.Controls.Add(median_IncomeLabel);
            this.Controls.Add(this.median_IncomeTextBox);
            this.Controls.Add(number_of_Computer_Jobs_Offered__Indeed_Label);
            this.Controls.Add(this.number_of_Computer_Jobs_Offered__Indeed_TextBox);
            this.Controls.Add(this.stateInfoBindingNavigator);
            this.Name = "StateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StateForm";
            this.Load += new System.EventHandler(this.StateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoBindingNavigator)).EndInit();
            this.stateInfoBindingNavigator.ResumeLayout(false);
            this.stateInfoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StateInfoDataSet stateInfoDataSet;
        private System.Windows.Forms.BindingSource stateInfoBindingSource;
        private StateInfoDataSetTableAdapters.StateInfoTableAdapter stateInfoTableAdapter;
        private StateInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stateInfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton stateInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox flag_DescriptionTextBox;
        private System.Windows.Forms.TextBox flowerTextBox;
        private System.Windows.Forms.TextBox birdTextBox;
        private System.Windows.Forms.TextBox colorsTextBox;
        private System.Windows.Forms.TextBox three_Largest_CitiesTextBox;
        private System.Windows.Forms.TextBox capitolTextBox;
        private System.Windows.Forms.TextBox median_IncomeTextBox;
        private System.Windows.Forms.TextBox number_of_Computer_Jobs_Offered__Indeed_TextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}