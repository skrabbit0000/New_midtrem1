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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }
        public tMember Member = new tMember();
        tShop Sshop = new tShop();
        
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void Shop_Load(object sender, EventArgs e)
        {
            MidDataBaseEntities dbContext = new MidDataBaseEntities();
            var q = (from p in dbContext.tShop
                     where p.fID == 3
                     select p).FirstOrDefault();
            Sshop.fName = q.fName;
            Sshop.fPrice = q.fPrice;

            lblShop1Name.Text = Sshop.fName;
            lblShop1Price.Text = Sshop.fPrice.ToString();
            pbxSHOP1.Image = Image.FromFile(q.fPhoto);
       }
        private void pbxSHOP1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >0)
                return;
            listBox1.Items.Add(Sshop.fName+"\t" + "價錢 " + Sshop.fPrice + "$");
        }
        Item itemform = new Item();
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            MidDataBaseEntities dbContext = new MidDataBaseEntities();
            if (listBox1.Items.Count == 0)
                return;
            if (MessageBox.Show("請問是否購買?", "是否購買", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var q = (from p in dbContext.tMember
                     where p.fId.Equals(Member.fId)
                     select p).FirstOrDefault();
            if (q.fGold < Sshop.fPrice)
            {
                MessageBox.Show("金額不足");
                return;
            }
            q.fGold = q.fGold-Sshop.fPrice;

            dbContext.SaveChanges();

            Form f = Application.OpenForms["Main"];
            ((Main)f).lblGold.Text = q.fGold.ToString(); //同步更新   


            //==============================================
            var q1 = (from p in dbContext.tShop
                     where p.fID.Equals(3)
                     select p).FirstOrDefault();
            
            itemform.Ssop.fID = q1.fID;
            itemform.Member.fId = q.fId;

            itemform.TopLevel = false;
            itemform.Dock = DockStyle.Fill;
            panel1.Controls.Add(itemform);//
            itemform.Show();
            //==============================================

        }
    }
}
