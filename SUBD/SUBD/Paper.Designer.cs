namespace SUBD
{
    partial class Paper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paper));
            System.Windows.Forms.Label paper_numberLabel;
            System.Windows.Forms.Label conclusion_dateLabel;
            System.Windows.Forms.Label dealership_idLabel;
            System.Windows.Forms.Label client_idLabel;
            System.Windows.Forms.Label car_idLabel;
            this.dataSet1 = new SUBD.DataSet1();
            this.paperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paperTableAdapter = new SUBD.DataSet1TableAdapters.PaperTableAdapter();
            this.tableAdapterManager = new SUBD.DataSet1TableAdapters.TableAdapterManager();
            this.paperBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.paperDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.paperBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.paper_numberTextBox = new System.Windows.Forms.TextBox();
            this.conclusion_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dealership_idTextBox = new System.Windows.Forms.TextBox();
            this.client_idTextBox = new System.Windows.Forms.TextBox();
            this.car_idTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            paper_numberLabel = new System.Windows.Forms.Label();
            conclusion_dateLabel = new System.Windows.Forms.Label();
            dealership_idLabel = new System.Windows.Forms.Label();
            client_idLabel = new System.Windows.Forms.Label();
            car_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingNavigator)).BeginInit();
            this.paperBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paperDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paperBindingSource
            // 
            this.paperBindingSource.DataMember = "Paper";
            this.paperBindingSource.DataSource = this.dataSet1;
            // 
            // paperTableAdapter
            // 
            this.paperTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.Car_with_defectsTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DealershipTableAdapter = null;
            this.tableAdapterManager.DefectTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.PaperTableAdapter = this.paperTableAdapter;
            this.tableAdapterManager.UpdateOrder = SUBD.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paperBindingNavigator
            // 
            this.paperBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paperBindingNavigator.BindingSource = this.paperBindingSource;
            this.paperBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paperBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paperBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paperBindingNavigatorSaveItem});
            this.paperBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paperBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paperBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paperBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paperBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paperBindingNavigator.Name = "paperBindingNavigator";
            this.paperBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paperBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.paperBindingNavigator.TabIndex = 0;
            this.paperBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // paperDataGridView
            // 
            this.paperDataGridView.AutoGenerateColumns = false;
            this.paperDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paperDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.paperDataGridView.DataSource = this.paperBindingSource;
            this.paperDataGridView.Location = new System.Drawing.Point(12, 28);
            this.paperDataGridView.Name = "paperDataGridView";
            this.paperDataGridView.Size = new System.Drawing.Size(546, 239);
            this.paperDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "paper_number";
            this.dataGridViewTextBoxColumn1.HeaderText = "paper_number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "conclusion_date";
            this.dataGridViewTextBoxColumn2.HeaderText = "conclusion_date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dealership_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "dealership_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "client_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "client_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "car_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "car_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // paperBindingNavigatorSaveItem
            // 
            this.paperBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paperBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paperBindingNavigatorSaveItem.Image")));
            this.paperBindingNavigatorSaveItem.Name = "paperBindingNavigatorSaveItem";
            this.paperBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.paperBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.paperBindingNavigatorSaveItem.Click += new System.EventHandler(this.paperBindingNavigatorSaveItem_Click);
            // 
            // paper_numberLabel
            // 
            paper_numberLabel.AutoSize = true;
            paper_numberLabel.Location = new System.Drawing.Point(123, 310);
            paper_numberLabel.Name = "paper_numberLabel";
            paper_numberLabel.Size = new System.Drawing.Size(75, 13);
            paper_numberLabel.TabIndex = 2;
            paper_numberLabel.Text = "paper number:";
            // 
            // paper_numberTextBox
            // 
            this.paper_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paperBindingSource, "paper_number", true));
            this.paper_numberTextBox.Location = new System.Drawing.Point(214, 307);
            this.paper_numberTextBox.Name = "paper_numberTextBox";
            this.paper_numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.paper_numberTextBox.TabIndex = 3;
            // 
            // conclusion_dateLabel
            // 
            conclusion_dateLabel.AutoSize = true;
            conclusion_dateLabel.Location = new System.Drawing.Point(123, 337);
            conclusion_dateLabel.Name = "conclusion_dateLabel";
            conclusion_dateLabel.Size = new System.Drawing.Size(85, 13);
            conclusion_dateLabel.TabIndex = 4;
            conclusion_dateLabel.Text = "conclusion date:";
            // 
            // conclusion_dateDateTimePicker
            // 
            this.conclusion_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paperBindingSource, "conclusion_date", true));
            this.conclusion_dateDateTimePicker.Location = new System.Drawing.Point(214, 333);
            this.conclusion_dateDateTimePicker.Name = "conclusion_dateDateTimePicker";
            this.conclusion_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.conclusion_dateDateTimePicker.TabIndex = 5;
            // 
            // dealership_idLabel
            // 
            dealership_idLabel.AutoSize = true;
            dealership_idLabel.Location = new System.Drawing.Point(123, 362);
            dealership_idLabel.Name = "dealership_idLabel";
            dealership_idLabel.Size = new System.Drawing.Size(69, 13);
            dealership_idLabel.TabIndex = 6;
            dealership_idLabel.Text = "dealership id:";
            // 
            // dealership_idTextBox
            // 
            this.dealership_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paperBindingSource, "dealership_id", true));
            this.dealership_idTextBox.Location = new System.Drawing.Point(214, 359);
            this.dealership_idTextBox.Name = "dealership_idTextBox";
            this.dealership_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.dealership_idTextBox.TabIndex = 7;
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Location = new System.Drawing.Point(123, 388);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new System.Drawing.Size(46, 13);
            client_idLabel.TabIndex = 8;
            client_idLabel.Text = "client id:";
            // 
            // client_idTextBox
            // 
            this.client_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paperBindingSource, "client_id", true));
            this.client_idTextBox.Location = new System.Drawing.Point(214, 385);
            this.client_idTextBox.Name = "client_idTextBox";
            this.client_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.client_idTextBox.TabIndex = 9;
            // 
            // car_idLabel
            // 
            car_idLabel.AutoSize = true;
            car_idLabel.Location = new System.Drawing.Point(123, 414);
            car_idLabel.Name = "car_idLabel";
            car_idLabel.Size = new System.Drawing.Size(36, 13);
            car_idLabel.TabIndex = 10;
            car_idLabel.Text = "car id:";
            // 
            // car_idTextBox
            // 
            this.car_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paperBindingSource, "car_id", true));
            this.car_idTextBox.Location = new System.Drawing.Point(214, 411);
            this.car_idTextBox.Name = "car_idTextBox";
            this.car_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.car_idTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Paper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(paper_numberLabel);
            this.Controls.Add(this.paper_numberTextBox);
            this.Controls.Add(conclusion_dateLabel);
            this.Controls.Add(this.conclusion_dateDateTimePicker);
            this.Controls.Add(dealership_idLabel);
            this.Controls.Add(this.dealership_idTextBox);
            this.Controls.Add(client_idLabel);
            this.Controls.Add(this.client_idTextBox);
            this.Controls.Add(car_idLabel);
            this.Controls.Add(this.car_idTextBox);
            this.Controls.Add(this.paperDataGridView);
            this.Controls.Add(this.paperBindingNavigator);
            this.Name = "Paper";
            this.Text = "Paper";
            this.Load += new System.EventHandler(this.Paper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingNavigator)).EndInit();
            this.paperBindingNavigator.ResumeLayout(false);
            this.paperBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paperDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource paperBindingSource;
        private DataSet1TableAdapters.PaperTableAdapter paperTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paperBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton paperBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView paperDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox paper_numberTextBox;
        private System.Windows.Forms.DateTimePicker conclusion_dateDateTimePicker;
        private System.Windows.Forms.TextBox dealership_idTextBox;
        private System.Windows.Forms.TextBox client_idTextBox;
        private System.Windows.Forms.TextBox car_idTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}