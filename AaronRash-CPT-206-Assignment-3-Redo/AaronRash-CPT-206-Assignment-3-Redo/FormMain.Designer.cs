namespace AaronRash_CPT_206_Assignment_3_Redo
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbStates = new System.Windows.Forms.ComboBox();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.bSelect = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.stateInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.stateInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInfoDataSet = new AaronRash_CPT_206_Assignment_3_Redo.StateInfoDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stateInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stateInfoTableAdapter = new AaronRash_CPT_206_Assignment_3_Redo.StateInfoDataSetTableAdapters.StateInfoTableAdapter();
            this.tableAdapterManager = new AaronRash_CPT_206_Assignment_3_Redo.StateInfoDataSetTableAdapters.TableAdapterManager();
            this.stateInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tNum = new System.Windows.Forms.TextBox();
            this.tMax = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bSearchNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbQuery = new System.Windows.Forms.ListBox();
            this.lbNumColumn = new System.Windows.Forms.ListBox();
            this.lbColumn = new System.Windows.Forms.ListBox();
            this.bClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoBindingNavigator)).BeginInit();
            this.stateInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSetBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStates
            // 
            this.cbStates.FormattingEnabled = true;
            this.cbStates.Location = new System.Drawing.Point(35, 330);
            this.cbStates.Name = "cbStates";
            this.cbStates.Size = new System.Drawing.Size(117, 21);
            this.cbStates.TabIndex = 0;
            // 
            // tSearch
            // 
            this.tSearch.Location = new System.Drawing.Point(6, 144);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(100, 20);
            this.tSearch.TabIndex = 2;
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(35, 290);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(75, 23);
            this.bSelect.TabIndex = 3;
            this.bSelect.Text = "Select State";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(1024, 464);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // stateInfoBindingNavigator
            // 
            this.stateInfoBindingNavigator.AddNewItem = null;
            this.stateInfoBindingNavigator.BindingSource = this.stateInfoBindingSource;
            this.stateInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stateInfoBindingNavigator.DeleteItem = null;
            this.stateInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.stateInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stateInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stateInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stateInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stateInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stateInfoBindingNavigator.Name = "stateInfoBindingNavigator";
            this.stateInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stateInfoBindingNavigator.Size = new System.Drawing.Size(1142, 25);
            this.stateInfoBindingNavigator.TabIndex = 5;
            this.stateInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // stateInfoBindingSource
            // 
            this.stateInfoBindingSource.DataMember = "StateInfo";
            this.stateInfoBindingSource.DataSource = this.stateInfoDataSet;
            // 
            // stateInfoDataSet
            // 
            this.stateInfoDataSet.DataSetName = "StateInfoDataSet";
            this.stateInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // stateInfoDataGridView
            // 
            this.stateInfoDataGridView.AutoGenerateColumns = false;
            this.stateInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.stateInfoDataGridView.DataSource = this.stateInfoBindingSource;
            this.stateInfoDataGridView.Location = new System.Drawing.Point(35, 39);
            this.stateInfoDataGridView.Name = "stateInfoDataGridView";
            this.stateInfoDataGridView.Size = new System.Drawing.Size(1064, 220);
            this.stateInfoDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "State";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "State";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Population";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.HeaderText = "Population";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Flag Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Flag Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Flower";
            this.dataGridViewTextBoxColumn4.HeaderText = "Flower";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Bird";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bird";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Colors";
            this.dataGridViewTextBoxColumn6.HeaderText = "Colors";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Three Largest Cities";
            this.dataGridViewTextBoxColumn7.HeaderText = "Three Largest Cities";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Capitol";
            this.dataGridViewTextBoxColumn8.HeaderText = "Capitol";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Median Income";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn9.HeaderText = "Median Income";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Number of Computer Jobs Offered (Indeed)";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn10.HeaderText = "Number of Computer Jobs Offered (Indeed)";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(6, 180);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 8;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bSearch);
            this.groupBox1.Controls.Add(this.lbColumn);
            this.groupBox1.Controls.Add(this.tSearch);
            this.groupBox1.Location = new System.Drawing.Point(296, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 209);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Text";
            // 
            // stateInfoTableAdapter
            // 
            this.stateInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StateInfoTableAdapter = this.stateInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AaronRash_CPT_206_Assignment_3_Redo.StateInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stateInfoDataSetBindingSource
            // 
            this.stateInfoDataSetBindingSource.DataSource = this.stateInfoDataSet;
            this.stateInfoDataSetBindingSource.Position = 0;
            // 
            // tNum
            // 
            this.tNum.Location = new System.Drawing.Point(105, 180);
            this.tNum.Name = "tNum";
            this.tNum.Size = new System.Drawing.Size(75, 20);
            this.tNum.TabIndex = 19;
            // 
            // tMax
            // 
            this.tMax.Location = new System.Drawing.Point(198, 180);
            this.tMax.Name = "tMax";
            this.tMax.Size = new System.Drawing.Size(75, 20);
            this.tMax.TabIndex = 20;
            this.tMax.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tMax);
            this.groupBox2.Controls.Add(this.bSearchNum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbQuery);
            this.groupBox2.Controls.Add(this.tNum);
            this.groupBox2.Controls.Add(this.lbNumColumn);
            this.groupBox2.Location = new System.Drawing.Point(613, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 215);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Max";
            this.label2.Visible = false;
            // 
            // bSearchNum
            // 
            this.bSearchNum.Location = new System.Drawing.Point(6, 180);
            this.bSearchNum.Name = "bSearchNum";
            this.bSearchNum.Size = new System.Drawing.Size(75, 23);
            this.bSearchNum.TabIndex = 22;
            this.bSearchNum.Text = "Search";
            this.bSearchNum.UseVisualStyleBackColor = true;
            this.bSearchNum.Click += new System.EventHandler(this.bSearchNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Min";
            this.label1.Visible = false;
            // 
            // lbQuery
            // 
            this.lbQuery.FormattingEnabled = true;
            this.lbQuery.Items.AddRange(new object[] {
            "Greater Than",
            "Less Than",
            "Between"});
            this.lbQuery.Location = new System.Drawing.Point(153, 40);
            this.lbQuery.Name = "lbQuery";
            this.lbQuery.Size = new System.Drawing.Size(120, 56);
            this.lbQuery.TabIndex = 25;
            this.lbQuery.SelectedIndexChanged += new System.EventHandler(this.lbQuery_SelectedIndexChanged);
            // 
            // lbNumColumn
            // 
            this.lbNumColumn.FormattingEnabled = true;
            this.lbNumColumn.Items.AddRange(new object[] {
            "Population",
            "Income",
            "Jobs"});
            this.lbNumColumn.Location = new System.Drawing.Point(6, 40);
            this.lbNumColumn.Name = "lbNumColumn";
            this.lbNumColumn.Size = new System.Drawing.Size(120, 56);
            this.lbNumColumn.TabIndex = 24;
            // 
            // lbColumn
            // 
            this.lbColumn.FormattingEnabled = true;
            this.lbColumn.Items.AddRange(new object[] {
            "State",
            "Flag",
            "Flower",
            "Bird",
            "Colors",
            "Cities",
            "Capitol"});
            this.lbColumn.Location = new System.Drawing.Point(6, 24);
            this.lbColumn.Name = "lbColumn";
            this.lbColumn.Size = new System.Drawing.Size(100, 95);
            this.lbColumn.TabIndex = 26;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(1024, 412);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 39);
            this.bClear.TabIndex = 22;
            this.bClear.Text = "Clear && Update";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Query";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 537);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stateInfoDataGridView);
            this.Controls.Add(this.stateInfoBindingNavigator);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.cbStates);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoBindingNavigator)).EndInit();
            this.stateInfoBindingNavigator.ResumeLayout(false);
            this.stateInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSetBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStates;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.Button bExit;
        private StateInfoDataSet stateInfoDataSet;
        private System.Windows.Forms.BindingSource stateInfoBindingSource;
        private StateInfoDataSetTableAdapters.StateInfoTableAdapter stateInfoTableAdapter;
        private StateInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stateInfoBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView stateInfoDataGridView;
        private System.Windows.Forms.BindingSource stateInfoDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tNum;
        private System.Windows.Forms.TextBox tMax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bSearchNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbNumColumn;
        private System.Windows.Forms.ListBox lbQuery;
        private System.Windows.Forms.ListBox lbColumn;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

