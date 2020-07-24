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
    public partial class CreatAcc : Form
    {
        public CreatAcc()
        {
            InitializeComponent();

            CMBupdate();
        }

        MidDataBaseEntities dbContext = new MidDataBaseEntities();
        tMember Member = new tMember();

        private void btnOK_Click(object sender, EventArgs e)
        {
            ADDmemberLinq();
        }
        public void ADDmemberLinq()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("請填妥姓名");
                return;
            }

            else if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("請填妥手機號碼");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtAccount.Text))
            {
                MessageBox.Show("請填妥帳號");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword1.Text))
            {
                MessageBox.Show("請填妥密碼");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword2.Text))
            {
                MessageBox.Show("請再次確認密碼");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("請填妥Email");
                return;
            }
            else if (txtPassword1.Text != txtPassword2.Text)
            {
                MessageBox.Show("兩次輸入密碼不依");
                timer1.Enabled = true;
                return;
            }
            Member.fName = txtName.Text;//姓名
            Member.fSex = cmbSex.Text;//性別
            Member.fBirthday = dtpBirthday.Value.ToString();//生日
            Member.fPhone = txtPhone.Text;//電話
            Member.fEmail = txtEmail.Text; //Email
            Member.fAddress = cmbAddress.Text;//地址
            Member.fAccount = txtAccount.Text;//帳號
            Member.fPassword = txtPassword1.Text;//密碼


            this.dbContext.tMember.Add(Member);
            this.dbContext.SaveChanges();

            MessageBox.Show("註冊帳號成功");
            timer1.Enabled = false;
            txtPassword1.BackColor = SystemColors.Window;//還原顏色
            txtPassword2.BackColor = SystemColors.Window;
            this.Close();
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
      
        bool TimerFlag = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtPassword1.BackColor = TimerFlag ? Color.Red : Color.Black;
            txtPassword2.BackColor = TimerFlag ? Color.Red : Color.Black;
            TimerFlag = !TimerFlag;
        }

        private void btnClose(object sender, EventArgs e)
        {
            Close();
        }

        bool Winflag;
        private void btnFullScreen(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            if (Winflag == true)
                this.WindowState = FormWindowState.Normal;
            Winflag = !Winflag;
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {

        }
    }
}
