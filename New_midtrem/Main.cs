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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }
        //  public int Fid;
        public tMember Member = new tMember();
        Form NowFrom = null;
        tNPC Copper = new tNPC();
        private void Main_Load(object sender, EventArgs e)
        {
           
            update();
        }
        void update ()
        {
            MidDataBaseEntities dbContext = new MidDataBaseEntities();
            var q = (from p in dbContext.tMember
                     where p.fId.Equals(Member.fId)
                     select p).FirstOrDefault();
            lblGold.Text = q.fGold.ToString();
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogIn l = (LogIn)Owner;
            l.Show();
        }

        private void btnClose(object sender, EventArgs e)
        {
            Close();
        }

        bool Winflag;
        private void btnFullScreen(object sender, EventArgs e)
        {
            if (Winflag == true)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(560, 315);//(1920-800)/2,(1080-450)/2
                //this.WindowState = FormWindowState.Normal;

            }
            Winflag = !Winflag;
        }

        Information InformationForm = new Information();
        Item ItemForm = new Item();
        Shop ShopForm = new Shop();

        private void btnInformationForm(object sender, EventArgs e)
        {
            if (NowFrom != null)
            {
                NowFrom.Hide();
            }
            NowFrom = InformationForm;

            InformationForm.TopLevel = false;
            InformationForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(InformationForm);

            InformationForm.Member.fID = Member.fId;  //Fid丟給Information         
            InformationForm.Show();

        }
        private void btnAddGold(object sender, EventArgs e)
        {
            addNPC();
            MidDataBaseEntities dbContext = new MidDataBaseEntities();
            var q = (from p in dbContext.tMember
                     where p.fId.Equals(Member.fId)
                     select p).FirstOrDefault();
        
             q.fGold = q.fGold+Copper.fGold;
                   
            lblGold.Text = q.fGold.ToString();

            dbContext.SaveChanges();
            //if (NowFrom == InformationForm)//如果是開個人資料頁面
            //{
            //    Form f = Application.OpenForms["Information"];
            //    ((Information)f).lblGold.Text = q.fGold.ToString(); //同步更新                
            //}
            //else if (NowFrom == ItemForm)//如果是開物品欄頁面
            //{
            //    Form f = Application.OpenForms["Item"];
            //    ((Item)f).lblGold.Text = q.fGold.ToString(); //同步更新
            //}

        }
        void addNPC()
        {
            MidDataBaseEntities dbContext = new MidDataBaseEntities();
            var q = (from p in dbContext.tNPC
                     where p.fID.Equals(1)//id寫死
                     select p).FirstOrDefault();

            Copper.fName = q.fName;
            Copper.fGold = q.fGold;
            

        }      
        private void bunItemForm(object sender, EventArgs e)
        {
            if (NowFrom != null)
            {
                NowFrom.Hide();
            }
            NowFrom = ItemForm;

            ItemForm.TopLevel = false;
            ItemForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(ItemForm);

            ItemForm.Member.fId = Member.fId;
          
            ItemForm.Show();
        }      
        private void btnSHOP(object sender, EventArgs e)
        {
            ShopForm.TopLevel = false;
            ShopForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(ShopForm);

            
            ShopForm.Member.fId = Member.fId;
            ShopForm.Show();
        }

    }
}
