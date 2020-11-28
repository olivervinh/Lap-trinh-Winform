using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class frmQLNS : Form
    {
        public frmQLNS()
        {
            InitializeComponent();
        }

        private void frmQLNS_Load(object sender, EventArgs e)
        {
            ckHoatDong.Checked = true;

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";

            radNam.Checked = true;

            lvNS.View = View.Details;

            lvNS.FullRowSelect = true;

            lvNS.Columns.Add("Tài khoản",80);
            lvNS.Columns.Add("Họ tên", 80);
            lvNS.Columns.Add("Ngày sinh", 80);
            lvNS.Columns.Add("Giới tính", 80);
            lvNS.Columns.Add("Trạng thái", 100);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           //kiem tra dieu kien
           if(string.IsNullOrWhiteSpace(txtTen.Text)||string.IsNullOrWhiteSpace(txtTK.Text))
            {
                txtTK.Text = "";
                txtTen.Text = "";
                MessageBox.Show("Bạn chưa nhập dữ liệu", "Thông báo", MessageBoxButtons.YesNoCancel);
            }
           else
            {
                int i = 0;
                int temp = 0;
                while(i<lvNS.Items.Count)
                {
                    if (lvNS.Items[i].Text == txtTK.Text) // nếu Items trong listview ==taikhoan.text 
                    {
                        temp = 1; // thì tam = 1;
                    }
                    i++; //tăng i lên 
                }
                if(temp==0)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = txtTK.Text;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtTen.Text });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dtpNgaySinh.Text });
                    if (radNam.Checked )
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Nam" });
                    }
                    if (radNu.Checked )
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Nữ" });
                    }
                    if (ckHoatDong.Checked )
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Hoạt động" });
                    }
                    if (ckHoatDong.Checked == false)
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Không Hoạt động" });
                    }
                    txtTen.Text = "";
                    txtTK.Text = "";
                    lvNS.Items.Add(item);
                }
               else
                {
                    
                    MessageBox.Show("Đã có tài khoản này", "Cảnh báo", MessageBoxButtons.YesNo);
                }


            }
        }

        private void lvNS_SelectedIndexChanged(object sender, EventArgs e)
        {
           foreach(ListViewItem item in lvNS.SelectedItems)
            {
                txtTK.Text = item.SubItems[0].Text;
                txtTen.Text = item.SubItems[1].Text;
                dtpNgaySinh.Text = item.SubItems[2].Text;
                if(item.SubItems[3].Text=="Nam")
                {
                    radNam.Checked=true;
                }
                if (item.SubItems[3].Text == "Nữ")
                {
                    radNu.Checked = true;
                }
                if(item.SubItems[4].Text=="Hoạt động")
                {
                    ckHoatDong.Checked = true;
                }
                if (item.SubItems[4].Text == "Không Hoạt động")
                {
                    ckHoatDong.Checked = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = 0;
            int tam = 0;
            while(i<lvNS.SelectedItems.Count)
            {
                if (lvNS.Items[i].Text == txtTK.Text)
                {
                    tam = i;
                }
                i++;
            }
            lvNS.Items[tam].SubItems[0].Text = txtTK.Text;                                                    
            lvNS.Items[tam].SubItems[1].Text = txtTen.Text; //item là dòng, subitem là từng phần tử trong dòng 
            lvNS.Items[tam].SubItems[2].Text = dtpNgaySinh.Text;
            if(radNam.Checked)
            {
                lvNS.Items[tam].SubItems[3].Text = "Nam" ;
            }
            if (radNu.Checked)
            {
                lvNS.Items[tam].SubItems[4].Text = "Nữ";
            }
            if (ckHoatDong.Checked)
            {
                lvNS.Items[tam].SubItems[4].Text = "Hoạt động";
            }
            if (ckHoatDong.Checked==false)
            {
                lvNS.Items[tam].SubItems[4].Text = "Không Hoạt động";
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           for(int i=0;i<lvNS.Items.Count;i++)
            {
                if(lvNS.Items[i].Selected)
                {
                    lvNS.Items.RemoveAt(i);
                }
            }
        }

        private void btnFrefres_Click(object sender, EventArgs e)
        {
            txtTK.Text = "";
            txtTen.Text = "";
            dtpNgaySinh.Text = "";
            radNam.Checked = true;
            ckHoatDong.Checked = true;
        }
    }
}
