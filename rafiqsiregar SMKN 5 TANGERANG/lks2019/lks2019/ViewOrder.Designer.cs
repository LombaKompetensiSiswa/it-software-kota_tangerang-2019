namespace lks2019
{
    partial class ViewOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.detailorderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lks2019DataSet2 = new lks2019.lks2019DataSet2();
            this.detailorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lks2019DataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lks2019DataSet3 = new lks2019.lks2019DataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.detailorderTableAdapter = new lks2019.lks2019DataSet1TableAdapters.DetailorderTableAdapter();
            this.detailorderTableAdapter1 = new lks2019.lks2019DataSet2TableAdapters.DetailorderTableAdapter();
            this.lks2019DataSet1 = new lks2019.lks2019DataSet1();
            this.detailorderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lks2019DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lks2019DataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lks2019DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lks2019DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 77);
            this.label1.TabIndex = 3;
            this.label1.Text = "Form View Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "OrderId";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detailorderBindingSource1, "Orderid", true));
            this.comboBox1.DataSource = this.detailorderBindingSource;
            this.comboBox1.DisplayMember = "Orderid";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "Orderid";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // detailorderBindingSource1
            // 
            this.detailorderBindingSource1.DataMember = "Detailorder";
            this.detailorderBindingSource1.DataSource = this.lks2019DataSet2;
            // 
            // lks2019DataSet2
            // 
            this.lks2019DataSet2.DataSetName = "lks2019DataSet2";
            this.lks2019DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailorderBindingSource
            // 
            this.detailorderBindingSource.DataMember = "Detailorder";
            this.detailorderBindingSource.DataSource = this.lks2019DataSet2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Menu,
            this.Qty,
            this.Action});
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 225);
            this.dataGridView1.TabIndex = 6;
            // 
            // Menu
            // 
            this.Menu.HeaderText = "Menu";
            this.Menu.Name = "Menu";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Action
            // 
            this.Action.DataSource = this.lks2019DataSet3BindingSource;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // lks2019DataSet3BindingSource
            // 
            this.lks2019DataSet3BindingSource.DataSource = this.lks2019DataSet3;
            this.lks2019DataSet3BindingSource.Position = 0;
            // 
            // lks2019DataSet3
            // 
            this.lks2019DataSet3.DataSetName = "lks2019DataSet3";
            this.lks2019DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detailorderTableAdapter
            // 
            this.detailorderTableAdapter.ClearBeforeFill = true;
            // 
            // detailorderTableAdapter1
            // 
            this.detailorderTableAdapter1.ClearBeforeFill = true;
            // 
            // lks2019DataSet1
            // 
            this.lks2019DataSet1.DataSetName = "lks2019DataSet1";
            this.lks2019DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailorderBindingSource2
            // 
            this.detailorderBindingSource2.DataMember = "Detailorder";
            this.detailorderBindingSource2.DataSource = this.lks2019DataSet1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(685, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrder";
            this.Load += new System.EventHandler(this.ViewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lks2019DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lks2019DataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lks2019DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lks2019DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private lks2019DataSet1TableAdapters.DetailorderTableAdapter detailorderTableAdapter;
        private lks2019DataSet2 lks2019DataSet2;
        private System.Windows.Forms.BindingSource detailorderBindingSource;
        private lks2019DataSet2TableAdapters.DetailorderTableAdapter detailorderTableAdapter1;
        private System.Windows.Forms.BindingSource detailorderBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewComboBoxColumn Action;
        private System.Windows.Forms.BindingSource lks2019DataSet3BindingSource;
        private lks2019DataSet3 lks2019DataSet3;
        private lks2019DataSet1 lks2019DataSet1;
        private System.Windows.Forms.BindingSource detailorderBindingSource2;
        private System.Windows.Forms.Button button2;
    }
}