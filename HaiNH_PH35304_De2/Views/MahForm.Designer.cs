namespace HaiNH_PH35304_De2.Views
{
    partial class MahForm
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
            groupBox1 = new GroupBox();
            cboNXB = new ComboBox();
            rdoOutOfStock = new RadioButton();
            rdoInStock = new RadioButton();
            txtMa = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnShow = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            txtSearch = new TextBox();
            label5 = new Label();
            dgvSach = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboNXB);
            groupBox1.Controls.Add(rdoOutOfStock);
            groupBox1.Controls.Add(rdoInStock);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 225);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // cboNXB
            // 
            cboNXB.FormattingEnabled = true;
            cboNXB.Items.AddRange(new object[] { "PN", "TP", "ND", "AD", "KÐ" });
            cboNXB.Location = new Point(149, 170);
            cboNXB.Name = "cboNXB";
            cboNXB.Size = new Size(359, 28);
            cboNXB.TabIndex = 8;
            // 
            // rdoOutOfStock
            // 
            rdoOutOfStock.AutoSize = true;
            rdoOutOfStock.Location = new Point(328, 128);
            rdoOutOfStock.Name = "rdoOutOfStock";
            rdoOutOfStock.Size = new Size(91, 24);
            rdoOutOfStock.TabIndex = 7;
            rdoOutOfStock.TabStop = true;
            rdoOutOfStock.Text = "Hết hàng";
            rdoOutOfStock.UseVisualStyleBackColor = true;
            // 
            // rdoInStock
            // 
            rdoInStock.AutoSize = true;
            rdoInStock.Location = new Point(156, 128);
            rdoInStock.Name = "rdoInStock";
            rdoInStock.Size = new Size(93, 24);
            rdoInStock.TabIndex = 6;
            rdoInStock.TabStop = true;
            rdoInStock.Text = "Còn hàng";
            rdoInStock.UseVisualStyleBackColor = true;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(149, 84);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(359, 27);
            txtMa.TabIndex = 5;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(149, 41);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(359, 27);
            txtTen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 175);
            label4.Name = "label4";
            label4.Size = new Size(117, 23);
            label4.TabIndex = 3;
            label4.Text = "Nhà xuất bản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 131);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 88);
            label2.Name = "label2";
            label2.Size = new Size(35, 23);
            label2.TabIndex = 1;
            label2.Text = "Mã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 42);
            label1.Name = "label1";
            label1.Size = new Size(37, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnShow);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(538, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 225);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Location = new Point(6, 175);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(237, 39);
            btnClear.TabIndex = 3;
            btnClear.Text = "Xóa form";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnShow
            // 
            btnShow.FlatStyle = FlatStyle.Popup;
            btnShow.Location = new Point(6, 128);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(237, 39);
            btnShow.TabIndex = 2;
            btnShow.Text = "Hiển thị";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Location = new Point(7, 78);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(237, 39);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(7, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(237, 39);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(1, 241);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(787, 68);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(150, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(630, 27);
            txtSearch.TabIndex = 10;
            txtSearch.Text = "Nhập tên để tìm kiếm";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 30);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 9;
            label5.Text = "Tìm kiếm";
            // 
            // dgvSach
            // 
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(12, 315);
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersWidth = 51;
            dgvSach.RowTemplate.Height = 29;
            dgvSach.Size = new Size(776, 230);
            dgvSach.TabIndex = 3;
            dgvSach.CellClick += dgvSach_CellClick;
            dgvSach.DataError += dgvSach_DataError;
            // 
            // MahForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(dgvSach);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MahForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MahForm";
            Load += MahForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoOutOfStock;
        private RadioButton rdoInStock;
        private TextBox txtMa;
        private TextBox txtTen;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboNXB;
        private GroupBox groupBox2;
        private Button btnClear;
        private Button btnShow;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox3;
        private TextBox txtSearch;
        private Label label5;
        private DataGridView dgvSach;
    }
}