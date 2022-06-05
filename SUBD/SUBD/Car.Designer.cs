namespace SUBD
{
    partial class Car
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
            System.Windows.Forms.Label car_idLabel;
            System.Windows.Forms.Label model_idLabel;
            System.Windows.Forms.Label engine_capacityLabel;
            System.Windows.Forms.Label engine_powerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            this.dataSet1 = new SUBD.DataSet1();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new SUBD.DataSet1TableAdapters.CarTableAdapter();
            this.tableAdapterManager = new SUBD.DataSet1TableAdapters.TableAdapterManager();
            this.carBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_idTextBox = new System.Windows.Forms.TextBox();
            this.model_idTextBox = new System.Windows.Forms.TextBox();
            this.engine_capacityTextBox = new System.Windows.Forms.TextBox();
            this.engine_powerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.carBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            car_idLabel = new System.Windows.Forms.Label();
            model_idLabel = new System.Windows.Forms.Label();
            engine_capacityLabel = new System.Windows.Forms.Label();
            engine_powerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).BeginInit();
            this.carBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.dataSet1;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.Car_with_defectsTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DealershipTableAdapter = null;
            this.tableAdapterManager.DefectTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.PaperTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SUBD.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carBindingNavigator
            // 
            this.carBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carBindingNavigator.BindingSource = this.carBindingSource;
            this.carBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.carBindingNavigatorSaveItem});
            this.carBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carBindingNavigator.Name = "carBindingNavigator";
            this.carBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carBindingNavigator.Size = new System.Drawing.Size(716, 25);
            this.carBindingNavigator.TabIndex = 0;
            this.carBindingNavigator.Text = "bindingNavigator1";
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
            // carDataGridView
            // 
            this.carDataGridView.AutoGenerateColumns = false;
            this.carDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.carDataGridView.DataSource = this.carBindingSource;
            this.carDataGridView.Location = new System.Drawing.Point(26, 39);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.Size = new System.Drawing.Size(448, 220);
            this.carDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "car_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "car_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "model_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "model_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "engine_capacity";
            this.dataGridViewTextBoxColumn3.HeaderText = "engine_capacity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "engine_power";
            this.dataGridViewTextBoxColumn4.HeaderText = "engine_power";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // car_idLabel
            // 
            car_idLabel.AutoSize = true;
            car_idLabel.Location = new System.Drawing.Point(132, 301);
            car_idLabel.Name = "car_idLabel";
            car_idLabel.Size = new System.Drawing.Size(36, 13);
            car_idLabel.TabIndex = 2;
            car_idLabel.Text = "car id:";
            // 
            // car_idTextBox
            // 
            this.car_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "car_id", true));
            this.car_idTextBox.Location = new System.Drawing.Point(223, 298);
            this.car_idTextBox.Name = "car_idTextBox";
            this.car_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.car_idTextBox.TabIndex = 3;
            // 
            // model_idLabel
            // 
            model_idLabel.AutoSize = true;
            model_idLabel.Location = new System.Drawing.Point(132, 327);
            model_idLabel.Name = "model_idLabel";
            model_idLabel.Size = new System.Drawing.Size(49, 13);
            model_idLabel.TabIndex = 4;
            model_idLabel.Text = "model id:";
            // 
            // model_idTextBox
            // 
            this.model_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "model_id", true));
            this.model_idTextBox.Location = new System.Drawing.Point(223, 324);
            this.model_idTextBox.Name = "model_idTextBox";
            this.model_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.model_idTextBox.TabIndex = 5;
            // 
            // engine_capacityLabel
            // 
            engine_capacityLabel.AutoSize = true;
            engine_capacityLabel.Location = new System.Drawing.Point(132, 353);
            engine_capacityLabel.Name = "engine_capacityLabel";
            engine_capacityLabel.Size = new System.Drawing.Size(85, 13);
            engine_capacityLabel.TabIndex = 6;
            engine_capacityLabel.Text = "engine capacity:";
            // 
            // engine_capacityTextBox
            // 
            this.engine_capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "engine_capacity", true));
            this.engine_capacityTextBox.Location = new System.Drawing.Point(223, 350);
            this.engine_capacityTextBox.Name = "engine_capacityTextBox";
            this.engine_capacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.engine_capacityTextBox.TabIndex = 7;
            // 
            // engine_powerLabel
            // 
            engine_powerLabel.AutoSize = true;
            engine_powerLabel.Location = new System.Drawing.Point(132, 379);
            engine_powerLabel.Name = "engine_powerLabel";
            engine_powerLabel.Size = new System.Drawing.Size(74, 13);
            engine_powerLabel.TabIndex = 8;
            engine_powerLabel.Text = "engine power:";
            // 
            // engine_powerTextBox
            // 
            this.engine_powerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "engine_power", true));
            this.engine_powerTextBox.Location = new System.Drawing.Point(223, 376);
            this.engine_powerTextBox.Name = "engine_powerTextBox";
            this.engine_powerTextBox.Size = new System.Drawing.Size(100, 20);
            this.engine_powerTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // carBindingNavigatorSaveItem
            // 
            this.carBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carBindingNavigatorSaveItem.Image")));
            this.carBindingNavigatorSaveItem.Name = "carBindingNavigatorSaveItem";
            this.carBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.carBindingNavigatorSaveItem.Click += new System.EventHandler(this.carBindingNavigatorSaveItem_Click);
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 509);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(car_idLabel);
            this.Controls.Add(this.car_idTextBox);
            this.Controls.Add(model_idLabel);
            this.Controls.Add(this.model_idTextBox);
            this.Controls.Add(engine_capacityLabel);
            this.Controls.Add(this.engine_capacityTextBox);
            this.Controls.Add(engine_powerLabel);
            this.Controls.Add(this.engine_powerTextBox);
            this.Controls.Add(this.carDataGridView);
            this.Controls.Add(this.carBindingNavigator);
            this.Name = "Car";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).EndInit();
            this.carBindingNavigator.ResumeLayout(false);
            this.carBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private DataSet1TableAdapters.CarTableAdapter carTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton carBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView carDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox car_idTextBox;
        private System.Windows.Forms.TextBox model_idTextBox;
        private System.Windows.Forms.TextBox engine_capacityTextBox;
        private System.Windows.Forms.TextBox engine_powerTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}