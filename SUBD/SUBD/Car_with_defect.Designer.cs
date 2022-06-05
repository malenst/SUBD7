namespace SUBD
{
    partial class Car_with_defect
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
            System.Windows.Forms.Label car_with_defects_idLabel;
            System.Windows.Forms.Label car_idLabel;
            System.Windows.Forms.Label defect_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_with_defect));
            this.dataSet1 = new SUBD.DataSet1();
            this.car_with_defectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_with_defectsTableAdapter = new SUBD.DataSet1TableAdapters.Car_with_defectsTableAdapter();
            this.tableAdapterManager = new SUBD.DataSet1TableAdapters.TableAdapterManager();
            this.car_with_defectsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.car_with_defectsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_with_defects_idTextBox = new System.Windows.Forms.TextBox();
            this.car_idTextBox = new System.Windows.Forms.TextBox();
            this.defect_idTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.car_with_defectsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            car_with_defects_idLabel = new System.Windows.Forms.Label();
            car_idLabel = new System.Windows.Forms.Label();
            defect_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_with_defectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_with_defectsBindingNavigator)).BeginInit();
            this.car_with_defectsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car_with_defectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // car_with_defectsBindingSource
            // 
            this.car_with_defectsBindingSource.DataMember = "Car_with_defects";
            this.car_with_defectsBindingSource.DataSource = this.dataSet1;
            // 
            // car_with_defectsTableAdapter
            // 
            this.car_with_defectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.Car_with_defectsTableAdapter = this.car_with_defectsTableAdapter;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DealershipTableAdapter = null;
            this.tableAdapterManager.DefectTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.PaperTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SUBD.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // car_with_defectsBindingNavigator
            // 
            this.car_with_defectsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.car_with_defectsBindingNavigator.BindingSource = this.car_with_defectsBindingSource;
            this.car_with_defectsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.car_with_defectsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.car_with_defectsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.car_with_defectsBindingNavigatorSaveItem});
            this.car_with_defectsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.car_with_defectsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.car_with_defectsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.car_with_defectsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.car_with_defectsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.car_with_defectsBindingNavigator.Name = "car_with_defectsBindingNavigator";
            this.car_with_defectsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.car_with_defectsBindingNavigator.Size = new System.Drawing.Size(643, 25);
            this.car_with_defectsBindingNavigator.TabIndex = 0;
            this.car_with_defectsBindingNavigator.Text = "bindingNavigator1";
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
            // car_with_defectsDataGridView
            // 
            this.car_with_defectsDataGridView.AutoGenerateColumns = false;
            this.car_with_defectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.car_with_defectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.car_with_defectsDataGridView.DataSource = this.car_with_defectsBindingSource;
            this.car_with_defectsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.car_with_defectsDataGridView.Name = "car_with_defectsDataGridView";
            this.car_with_defectsDataGridView.Size = new System.Drawing.Size(359, 226);
            this.car_with_defectsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "car_with_defects_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "car_with_defects_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "car_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "car_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "defect_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "defect_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // car_with_defects_idLabel
            // 
            car_with_defects_idLabel.AutoSize = true;
            car_with_defects_idLabel.Location = new System.Drawing.Point(67, 297);
            car_with_defects_idLabel.Name = "car_with_defects_idLabel";
            car_with_defects_idLabel.Size = new System.Drawing.Size(96, 13);
            car_with_defects_idLabel.TabIndex = 2;
            car_with_defects_idLabel.Text = "car with defects id:";
            // 
            // car_with_defects_idTextBox
            // 
            this.car_with_defects_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_with_defectsBindingSource, "car_with_defects_id", true));
            this.car_with_defects_idTextBox.Location = new System.Drawing.Point(169, 294);
            this.car_with_defects_idTextBox.Name = "car_with_defects_idTextBox";
            this.car_with_defects_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.car_with_defects_idTextBox.TabIndex = 3;
            // 
            // car_idLabel
            // 
            car_idLabel.AutoSize = true;
            car_idLabel.Location = new System.Drawing.Point(67, 323);
            car_idLabel.Name = "car_idLabel";
            car_idLabel.Size = new System.Drawing.Size(36, 13);
            car_idLabel.TabIndex = 4;
            car_idLabel.Text = "car id:";
            // 
            // car_idTextBox
            // 
            this.car_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_with_defectsBindingSource, "car_id", true));
            this.car_idTextBox.Location = new System.Drawing.Point(169, 320);
            this.car_idTextBox.Name = "car_idTextBox";
            this.car_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.car_idTextBox.TabIndex = 5;
            // 
            // defect_idLabel
            // 
            defect_idLabel.AutoSize = true;
            defect_idLabel.Location = new System.Drawing.Point(67, 349);
            defect_idLabel.Name = "defect_idLabel";
            defect_idLabel.Size = new System.Drawing.Size(51, 13);
            defect_idLabel.TabIndex = 6;
            defect_idLabel.Text = "defect id:";
            // 
            // defect_idTextBox
            // 
            this.defect_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_with_defectsBindingSource, "defect_id", true));
            this.defect_idTextBox.Location = new System.Drawing.Point(169, 346);
            this.defect_idTextBox.Name = "defect_idTextBox";
            this.defect_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.defect_idTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 8;
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
            // car_with_defectsBindingNavigatorSaveItem
            // 
            this.car_with_defectsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.car_with_defectsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("car_with_defectsBindingNavigatorSaveItem.Image")));
            this.car_with_defectsBindingNavigatorSaveItem.Name = "car_with_defectsBindingNavigatorSaveItem";
            this.car_with_defectsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.car_with_defectsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.car_with_defectsBindingNavigatorSaveItem.Click += new System.EventHandler(this.car_with_defectsBindingNavigatorSaveItem_Click);
            // 
            // Car_with_defect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(car_with_defects_idLabel);
            this.Controls.Add(this.car_with_defects_idTextBox);
            this.Controls.Add(car_idLabel);
            this.Controls.Add(this.car_idTextBox);
            this.Controls.Add(defect_idLabel);
            this.Controls.Add(this.defect_idTextBox);
            this.Controls.Add(this.car_with_defectsDataGridView);
            this.Controls.Add(this.car_with_defectsBindingNavigator);
            this.Name = "Car_with_defect";
            this.Text = "Car_with_defect";
            this.Load += new System.EventHandler(this.Car_with_defect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_with_defectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_with_defectsBindingNavigator)).EndInit();
            this.car_with_defectsBindingNavigator.ResumeLayout(false);
            this.car_with_defectsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car_with_defectsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource car_with_defectsBindingSource;
        private DataSet1TableAdapters.Car_with_defectsTableAdapter car_with_defectsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator car_with_defectsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton car_with_defectsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView car_with_defectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox car_with_defects_idTextBox;
        private System.Windows.Forms.TextBox car_idTextBox;
        private System.Windows.Forms.TextBox defect_idTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}