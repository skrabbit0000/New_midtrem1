using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_midtrem
{
    public partial class Information : Form
    {
        MidDataBaseEntities dbContext = new MidDataBaseEntities();
       public cMember Member = new cMember();

        //  public int Fid; //接到Login => Main =>的q.fid
        public Information()
        {
            InitializeComponent();
            CMBupdate();
        }
        private void btnClose(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            vEnabled();

            var q = (from p in this.dbContext.tMember
                     where p.fId.Equals(Member.fID)
                     select p).FirstOrDefault();

            txtName.Text = q.fName; //顯示資料在畫面上
            cmbSex.Text = q.fSex;
            txtPhone.Text = q.fPhone;
            dtpBirthday.Value = DateTime.Parse(q.fBirthday);
            cmbAddress.Text = q.fAddress;
            txtEmail.Text = q.fEmail;

            if (q.fPhoto == null) return; //第一次沒新增圖片時 例外
            if (q.fPhoto != null) lblpic.Visible = false;
            pictureBox1.Image = Image.FromFile(q.fPhoto);            
        }     
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "會員圖片|*.jpg|會員圖片|*.png";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                lblpic.Visible = false;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                Member.fPhoto = openFileDialog1.FileName;
            }
        }

        private void btnSave(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否儲存?", "是否儲存", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var q = (from p in this.dbContext.tMember
                     where p.fId.Equals(Member.fID)
                     select p).FirstOrDefault();

            if (Member.fPhoto != null)
            {
                q.fPhoto = Member.fPhoto;
            }
            q.fName = txtName.Text;
            q.fSex = cmbSex.Text;
            q.fBirthday = dtpBirthday.Value.ToString();
            q.fEmail = txtEmail.Text;
            q.fPhone = txtPhone.Text;
            q.fAddress = cmbAddress.Text;
            this.dbContext.SaveChanges();
        }

        private void btnModify(object sender, EventArgs e)
        {
            vAbled();
        }
        void CMBupdate()
        {
            cmbSex.BeginUpdate();
            cmbSex.Items.Add("男");
            cmbSex.Items.Add("女");
            cmbSex.EndUpdate();
            //------------------性別COMBOBOX更新------------------
            cmbAddress.BeginUpdate();
            cmbAddress.Items.Add("基隆市");
            cmbAddress.Items.Add("嘉義市");
            cmbAddress.Items.Add("台北市");
            cmbAddress.Items.Add("新北市");
            cmbAddress.Items.Add("台南市");
            cmbAddress.Items.Add("桃園市");
            cmbAddress.Items.Add("高雄市");
            cmbAddress.Items.Add("新竹市");
            cmbAddress.Items.Add("屏東縣");
            cmbAddress.Items.Add("新竹縣");
            cmbAddress.Items.Add("台東縣");
            cmbAddress.Items.Add("苗栗縣");
            cmbAddress.Items.Add("花蓮縣");
            cmbAddress.Items.Add("台中市");
            cmbAddress.Items.Add("宜蘭縣");
            cmbAddress.Items.Add("彰化縣");
            cmbAddress.Items.Add("澎湖縣");
            cmbAddress.Items.Add("南投縣");
            cmbAddress.Items.Add("金門縣");
            cmbAddress.Items.Add("雲林縣");
            cmbAddress.Items.Add("連江縣");
            //------------------地址COMBOBOX更新------------------
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            vEnabled();
            //------------打開個人資訊無法修改資料----------------
        }
        void vEnabled()
        {
            txtEmail.Enabled = false;
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            dtpBirthday.Enabled = false;
            cmbAddress.Enabled = false;
            cmbSex.Enabled = false;
            pictureBox1.Enabled = false;
            //------------打開個人資訊無法修改資料----------------
        }
        void vAbled()
        {
            txtEmail.Enabled = true;
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            dtpBirthday.Enabled = true;
            cmbAddress.Enabled = true;
            cmbSex.Enabled = true;
            pictureBox1.Enabled = true;
        }
    }
}
