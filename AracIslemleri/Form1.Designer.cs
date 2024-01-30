namespace AracIslemleri
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label markaLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label stokLabel;
            System.Windows.Forms.Label fiyatLabel;
            System.Windows.Forms.Label renkLabel;
            this.aracDataSet = new AracIslemleri.AracDataSet();
            this.aracTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracTableTableAdapter = new AracIslemleri.AracDataSetTableAdapters.AracTableTableAdapter();
            this.tableAdapterManager = new AracIslemleri.AracDataSetTableAdapters.TableAdapterManager();
            this.aracTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aracTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.stokTextBox = new System.Windows.Forms.TextBox();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.renkTextBox = new System.Windows.Forms.TextBox();
            this.aracTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            markaLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            stokLabel = new System.Windows.Forms.Label();
            fiyatLabel = new System.Windows.Forms.Label();
            renkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aracDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTableBindingNavigator)).BeginInit();
            this.aracTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aracDataSet
            // 
            this.aracDataSet.DataSetName = "AracDataSet";
            this.aracDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aracTableBindingSource
            // 
            this.aracTableBindingSource.DataMember = "AracTable";
            this.aracTableBindingSource.DataSource = this.aracDataSet;
            // 
            // aracTableTableAdapter
            // 
            this.aracTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AracTableTableAdapter = this.aracTableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AracIslemleri.AracDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aracTableBindingNavigator
            // 
            this.aracTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aracTableBindingNavigator.BindingSource = this.aracTableBindingSource;
            this.aracTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aracTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aracTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aracTableBindingNavigatorSaveItem});
            this.aracTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aracTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aracTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aracTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aracTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aracTableBindingNavigator.Name = "aracTableBindingNavigator";
            this.aracTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aracTableBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.aracTableBindingNavigator.TabIndex = 0;
            this.aracTableBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // aracTableBindingNavigatorSaveItem
            // 
            this.aracTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aracTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aracTableBindingNavigatorSaveItem.Image")));
            this.aracTableBindingNavigatorSaveItem.Name = "aracTableBindingNavigatorSaveItem";
            this.aracTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.aracTableBindingNavigatorSaveItem.Text = "Save Data";
            this.aracTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.aracTableBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(33, 57);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aracTableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(58, 54);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // markaLabel
            // 
            markaLabel.AutoSize = true;
            markaLabel.Location = new System.Drawing.Point(47, 97);
            markaLabel.Name = "markaLabel";
            markaLabel.Size = new System.Drawing.Size(40, 13);
            markaLabel.TabIndex = 3;
            markaLabel.Text = "Marka:";
            // 
            // markaTextBox
            // 
            this.markaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aracTableBindingSource, "Marka", true));
            this.markaTextBox.Location = new System.Drawing.Point(93, 94);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(100, 20);
            this.markaTextBox.TabIndex = 4;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(55, 144);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 5;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aracTableBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(100, 141);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 6;
            // 
            // stokLabel
            // 
            stokLabel.AutoSize = true;
            stokLabel.Location = new System.Drawing.Point(192, 53);
            stokLabel.Name = "stokLabel";
            stokLabel.Size = new System.Drawing.Size(32, 13);
            stokLabel.TabIndex = 7;
            stokLabel.Text = "Stok:";
            // 
            // stokTextBox
            // 
            this.stokTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aracTableBindingSource, "Stok", true));
            this.stokTextBox.Location = new System.Drawing.Point(230, 50);
            this.stokTextBox.Name = "stokTextBox";
            this.stokTextBox.Size = new System.Drawing.Size(100, 20);
            this.stokTextBox.TabIndex = 8;
            // 
            // fiyatLabel
            // 
            fiyatLabel.AutoSize = true;
            fiyatLabel.Location = new System.Drawing.Point(212, 104);
            fiyatLabel.Name = "fiyatLabel";
            fiyatLabel.Size = new System.Drawing.Size(32, 13);
            fiyatLabel.TabIndex = 9;
            fiyatLabel.Text = "Fiyat:";
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aracTableBindingSource, "Fiyat", true));
            this.fiyatTextBox.Location = new System.Drawing.Point(250, 101);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(100, 20);
            this.fiyatTextBox.TabIndex = 10;
            // 
            // renkLabel
            // 
            renkLabel.AutoSize = true;
            renkLabel.Location = new System.Drawing.Point(214, 156);
            renkLabel.Name = "renkLabel";
            renkLabel.Size = new System.Drawing.Size(36, 13);
            renkLabel.TabIndex = 11;
            renkLabel.Text = "Renk:";
            // 
            // renkTextBox
            // 
            this.renkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aracTableBindingSource, "Renk", true));
            this.renkTextBox.Location = new System.Drawing.Point(256, 153);
            this.renkTextBox.Name = "renkTextBox";
            this.renkTextBox.Size = new System.Drawing.Size(100, 20);
            this.renkTextBox.TabIndex = 12;
            // 
            // aracTableDataGridView
            // 
            this.aracTableDataGridView.AutoGenerateColumns = false;
            this.aracTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aracTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.aracTableDataGridView.DataSource = this.aracTableBindingSource;
            this.aracTableDataGridView.Location = new System.Drawing.Point(36, 179);
            this.aracTableDataGridView.Name = "aracTableDataGridView";
            this.aracTableDataGridView.Size = new System.Drawing.Size(587, 220);
            this.aracTableDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Marka";
            this.dataGridViewTextBoxColumn2.HeaderText = "Marka";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Stok";
            this.dataGridViewTextBoxColumn4.HeaderText = "Stok";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fiyat";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fiyat";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Renk";
            this.dataGridViewTextBoxColumn6.HeaderText = "Renk";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.aracTableDataGridView);
            this.Controls.Add(renkLabel);
            this.Controls.Add(this.renkTextBox);
            this.Controls.Add(fiyatLabel);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(stokLabel);
            this.Controls.Add(this.stokTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(markaLabel);
            this.Controls.Add(this.markaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.aracTableBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aracDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTableBindingNavigator)).EndInit();
            this.aracTableBindingNavigator.ResumeLayout(false);
            this.aracTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AracDataSet aracDataSet;
        private System.Windows.Forms.BindingSource aracTableBindingSource;
        private AracDataSetTableAdapters.AracTableTableAdapter aracTableTableAdapter;
        private AracDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aracTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aracTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox stokTextBox;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.TextBox renkTextBox;
        private System.Windows.Forms.DataGridView aracTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

