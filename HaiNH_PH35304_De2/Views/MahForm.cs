using De2.DomainClass;
using De2.Services;
using HaiNH_PH35304_De2.Services;

namespace HaiNH_PH35304_De2.Views
{
    public partial class MahForm : Form
    {
        private const string CON_HANG = "Còn hàng";
        private const string HET_HANG = "Hết hàng";
        List<Sach>? lstSach = null;
        List<Nxb>? lstNxb = null;
        SachService sachService = new();
        NXBService nxbService = new();

        public MahForm()
        {
            InitializeComponent();
        }

        private void MahForm_Load(object sender, EventArgs e)
        {
            lstNxb = nxbService.GetAll();
            cboNXB.DataSource = lstNxb;
            cboNXB.DisplayMember = "Ten";
            cboNXB.ValueMember = "Id";
        }

        private void ShowGridView()
        {
            dgvSach.DataSource = lstSach;
            dgvSach.Columns[0].HeaderText = "STT";
            dgvSach.Columns[1].HeaderText = "Mã";
            dgvSach.Columns[2].HeaderText = "Tên";
            dgvSach.Columns[3].Visible = false;
            dgvSach.Columns[4].Visible = false;
            dgvSach.Columns[5].Visible = false;
            dgvSach.Columns[6].Visible = false;
            dgvSach.Columns[7].Visible = false;
            dgvSach.Columns[8].Visible = false;
            dgvSach.Columns.Add("Ten", "Nhà xuất bản ");    
            foreach (DataGridViewRow row in dgvSach.Rows)
            {
                Sach sach = (Sach)row.DataBoundItem;
                Guid? nxbId = sach.IdNxb.GetValueOrDefault();
                Nxb? nxb = lstNxb?.FirstOrDefault(x => x.Id == nxbId);
                row.Cells[9].Value = nxb != null ? nxb.Ten : "Buôn lậu";
            }

            if (lstSach != null && lstSach.Count > 0)
            {
                dgvSach.Columns[0].Selected = true;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstSach = sachService.GetAll();
            ShowGridView();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.RowIndex >= 0)
            {
                txtMa.Text = dgvSach.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtTen.Text = dgvSach.Rows[e.RowIndex].Cells[2].Value?.ToString();
                string? trangThai = dgvSach.Rows[e.RowIndex].Cells[3].Value?.ToString();
                switch (trangThai)
                {
                    case CON_HANG:
                        rdoInStock.Checked = true;
                        break;
                    case HET_HANG:
                        rdoOutOfStock.Checked = true;
                        break;
                }
                string? tenNXB = dgvSach.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (!string.IsNullOrEmpty(tenNXB))
                {
                    Nxb selectedNxb = lstNxb.FirstOrDefault(nxb => nxb.Ten == tenNXB);
                    if (selectedNxb != null)
                    {
                        cboNXB.SelectedItem = selectedNxb;
                    }
                }
            }
        }

        private void ClearForm()
        {
            txtTen.Text = string.Empty;
            txtMa.Text = string.Empty;
            rdoInStock.Checked = true;
            cboNXB.SelectedIndex = -1;
            txtSearch.Text = "Nhập tên để tìm kiếm";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                return;
            }

            lstSach = sachService.FindByName(txtSearch.Text);
            dgvSach.DataSource = lstSach;
            ShowGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text)
                || string.IsNullOrWhiteSpace(txtMa.Text))
            {
                return;
            }

            string maSach = txtMa.Text;
            if (sachService.IsMaSachExists(maSach))
            {
                MessageBox.Show("Mã sách đã tồn tại!");
                return;
            }

            Sach sach = new Sach();
            sach.Ten = txtTen.Text;
            sach.Ma = maSach;

            if (rdoInStock.Checked)
            {
                sach.TrangThai = 1;
            }
            else
            {
                sach.TrangThai = 0;
            }
            sachService.Add(sach);
            lstSach = sachService.GetAll();
            MessageBox.Show("Thêm sách thành công!");
            ShowGridView();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                return;
            }

            if (dgvSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!");
                return;
            }

            DataGridViewRow selectedRow = dgvSach.SelectedRows[0];
            Sach selectedSach = (Sach)selectedRow.DataBoundItem;

            selectedSach.Ten = txtTen.Text;

            if (rdoInStock.Checked)
            {
                selectedSach.TrangThai = 1;
            }
            else
            {
                selectedSach.TrangThai = 0;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn sửa sách không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                sachService.Update(selectedSach);
                lstSach = sachService.GetAll();
                MessageBox.Show("Sửa sách thành công!");
                ShowGridView();
                ClearForm();
            }
        }

        private void dgvSach_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if ((e.Context & DataGridViewDataErrorContexts.Display) != 0)
            {
                if (e.ColumnIndex == 6)
                {
                    dgvSach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Buôn lậu";
                    e.ThrowException = false;
                }
            }
        }
    }
}
