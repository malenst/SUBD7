namespace SUBD
{
    partial class Defect
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
            System.Windows.Forms.Label defect_idLabel;
            System.Windows.Forms.Label defect_nameLabel;
            System.Windows.Forms.Label discount_amountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Defect));
            this.dataSet1 = new SUBD.DataSet1();
            this.defectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defectTableAdapter = new SUBD.DataSet1TableAdapters.DefectTableAdapter();
            this.tableAdapterManager = new SUBD.DataSet1TableAdapters.TableAdapterManager();
            this.defectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.defectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defect_idTextBox = new System.Windows.Forms.TextBox();
            this.defect_nameTextBox = new System.Windows.Forms.TextBox();
            this.discount_amountTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.defectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            defect_idLabel = new System.Windows.Forms.Label();
            defect_nameLabel = new System.Windows.Forms.Label();
            discount_amountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectBindingNavigator)).BeginInit();
            this.defectBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // defectBindingSource
            // 
            this.defectBindingSource.DataMember = "Defect";
            this.defectBindingSource.DataSource = this.dataSet1;
            // 
            // defectTableAdapter
            // 
            this.defectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.Car_with_defectsTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DealershipTableAdapter = null;
            this.tableAdapterManager.DefectTableAdapter = this.defectTableAdapter;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.PaperTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SUBD.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // defectBindingNavigator
            // 
            this.defectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.defectBindingNavigator.BindingSource = this.defectBindingSource;
            this.defectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.defectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.defectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.defectBindingNavigatorSaveItem});
            this.defectBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.defectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.defectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.defectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.defectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.defectBindingNavigator.Name = "defectBindingNavigator";
            this.defectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.defectBindingNavigator.Size = new System.Drawing.Size(617, 25);
            this.defectBindingNavigator.TabIndex = 0;
            this.defectBindingNavigator.Text = "bindingNavigator1";
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
            // defectDataGridView
            // 
            this.defectDataGridView.AutoGenerateColumns = false;
            this.defectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.defectDataGridView.DataSource = this.defectBindingSource;
            this.defectDataGridView.Location = new System.Drawing.Point(21, 38);
            this.defectDataGridView.Name = "defectDataGridView";
            this.defectDataGridView.Size = new System.Drawing.Size(357, 220);
            this.defectDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "defect_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "defect_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "defect_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "defect_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "discount_amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "discount_amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // defect_idLabel
            // 
            defect_idLabel.AutoSize = true;
            defect_idLabel.Location = new System.Drawing.Point(88, 301);
            defect_idLabel.Name = "defect_idLabel";
            defect_idLabel.Size = new System.Drawing.Size(51, 13);
            defect_idLabel.TabIndex = 2;
            defect_idLabel.Text = "defect id:";
            // 
            // defect_idTextBox
            // 
            this.defect_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.defectBindingSource, "defect_id", true));
            this.defect_idTextBox.Location = new System.Drawing.Point(182, 298);
            this.defect_idTextBox.Name = "defect_idTextBox";
            this.defect_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.defect_idTextBox.TabIndex = 3;
            // 
            // defect_nameLabel
            // 
            defect_nameLabel.AutoSize = true;
            defect_nameLabel.Location = new System.Drawing.Point(88, 327);
            defect_nameLabel.Name = "defect_nameLabel";
            defect_nameLabel.Size = new System.Drawing.Size(69, 13);
            defect_nameLabel.TabIndex = 4;
            defect_nameLabel.Text = "defect name:";
            // 
            // defect_nameTextBox
            // 
            this.defect_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.defectBindingSource, "defect_name", true));
            this.defect_nameTextBox.Location = new System.Drawing.Point(182, 324);
            this.defect_nameTextBox.Name = "defect_nameTextBox";
            this.defect_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.defect_nameTextBox.TabIndex = 5;
            // 
            // discount_amountLabel
            // 
            discount_amountLabel.AutoSize = true;
            discount_amountLabel.Location = new System.Drawing.Point(88, 353);
            discount_amountLabel.Name = "discount_amountLabel";
            discount_amountLabel.Size = new System.Drawing.Size(88, 13);
            discount_amountLabel.TabIndex = 6;
            discount_amountLabel.Text = "discount amount:";
            // 
            // discount_amountTextBox
            // 
            this.discount_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.defectBindingSource, "discount_amount", true));
            this.discount_amountTextBox.Location = new System.Drawing.Point(182, 350);
            this.discount_amountTextBox.Name = "discount_amountTextBox";
            this.discount_amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discount_amountTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
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
            // defectBindingNavigatorSaveItem
            // 
            this.defectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.defectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("defectBindingNavigatorSaveItem.Image")));
            this.defectBindingNavigatorSaveItem.Name = "defectBindingNavigatorSaveItem";
            this.defectBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.defectBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.defectBindingNavigatorSaveItem.Click += new System.EventHandler(this.defectBindingNavigatorSaveItem_Click);
            // 
            // Defect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(defect_idLabel);
            this.Controls.Add(this.defect_idTextBox);
            this.Controls.Add(defect_nameLabel);
            this.Controls.Add(this.defect_nameTextBox);
            this.Controls.Add(discount_amountLabel);
            this.Controls.Add(this.discount_amountTextBox);
            this.Controls.Add(this.defectDataGridView);
            this.Controls.Add(this.defectBindingNavigator);
            this.Name = "Defect";
            this.Text = "Defect";
            this.Load += new System.EventHandler(this.Defect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectBindingNavigator)).EndInit();
            this.defectBindingNavigator.ResumeLayout(false);
            this.defectBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource defectBindingSource;
        private DataSet1TableAdapters.DefectTableAdapter defectTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator defectBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton defectBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView defectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox defect_idTextBox;
        private System.Windows.Forms.TextBox defect_nameTextBox;
        private System.Windows.Forms.TextBox discount_amountTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}