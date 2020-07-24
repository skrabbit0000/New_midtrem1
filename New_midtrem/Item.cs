using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace New_midtrem
{
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }
        public tMember Member = new tMember();
        public fItemBox IitemBox = new fItemBox();
        public tShop Ssop = new tShop();

        private void btnCls(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Item_Load(object sender, EventArgs e)
        {      
            MidDataBaseEntities dbContext = new MidDataBaseEntities();
            var q = (from p in dbContext.fItemBox
                     from c in dbContext.tShop
                     from m in dbContext.tMember
                     where p.fID == Member.fId && p.fID == c.fID
                     select c).FirstOrDefault();

            for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    PictureBox btn1 = new PictureBox();
                    btn1.Height = 50;
                    btn1.Width = 50;
                    btn1.Location = new Point(20 + 60 * (j - 1), 50 + 60 * (i - 1));
                    btn1.Name = "btn" + j;
                    btn1.Text = btn1.Name;
                    btn1.BorderStyle = BorderStyle.Fixed3D;
                    this.Controls.Add(btn1);
                    if (i == 2)
                    {
                        btn1.Name = "btn" + (j + 4);
                        btn1.Text = btn1.Name;
                        btn1.BorderStyle = BorderStyle.Fixed3D;
                        this.Controls.Add(btn1);
                    }
                    if (btn1.Name == "btn1"&& q!=null)
                    {
                        btn1.Image = Image.FromFile(q.fPhoto);
                        btn1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }

            InitializeTimer();
        }
        private void InitializeTimer()
        {

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            // Enable timer.  
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Ssop.fID == 0 || Member.fId == 0)
                return;

            MidDataBaseEntities dbContext = new MidDataBaseEntities();

            IitemBox.fID = Ssop.fID;
            IitemBox.fMemberID = Member.fId;
            dbContext.fItemBox.Add(IitemBox);
            dbContext.SaveChanges();
            if (IitemBox.fID > 0)
            {
                timer1.Enabled = false;
            }
            //if (Ssop.fID == 0)
            //{
            //    timer1.Enabled = true;
            //}
            //================================================

         
        }
    }
}


