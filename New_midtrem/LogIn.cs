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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        MidDataBaseEntities dbContext = new MidDataBaseEntities();
        //public int Fid;
        cMember Member = new cMember();
        private void btnREG_Click(object sender, EventArgs e)
        {
            CreatAcc f = new CreatAcc();
            f.ShowDialog();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            var q = (from p in this.dbContext.tMember
                    where p.fAccount.Equals(txtAcc.Text)&&
                    p.fPassword.Equals(txtPw.Text)
                    select p).FirstOrDefault();

            if (q == null)
            {
                MessageBox.Show("請輸入正確帳號密碼");
            }          
            else
            {
                this.Hide();
                Main f = new Main();
                Member.fID = q.fId; //全域變數接住q.fId
                f.Member.fId = Member.fID; //Member.fID丟給MAIN where 
                f.Owner = this;
                f.Show();
            }
        }

        private void btnClose(object sender, EventArgs e)
        {
            Close();
        }
        bool Winflag ;
        private void btnFullScreen(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            if(Winflag == true)
            this.WindowState = FormWindowState.Normal;
            Winflag = !Winflag;
        }
    }
}
