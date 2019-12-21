using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteUI
{
    public partial class day10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            Allno mynum = new Allno();
            mynum.fristNum = Convert.ToInt32(TextBox1.Text.Trim());
            mynum.lastNum = Convert.ToInt32(TextBox2.Text.Trim());
            Addfn(mynum);

        }
        Allno mycss = new Allno();
        void Addfn(Allno an)
        {
            Label1.Text = (an.fristNum + an.lastNum).ToString();
        }
    
        protected void btnsub_Click(object sender, EventArgs e)
        {
            Allno mynum = new Allno();
            mynum.fristNum = Convert.ToInt32(TextBox1.Text.Trim());
            mynum.lastNum = Convert.ToInt32(TextBox2.Text.Trim());
            Subfn(mynum);

        }
        Allno Mycss = new Allno();
        void Subfn(Allno an)
        {
            Label1.Text = (an.fristNum - an.lastNum).ToString();
        }

        protected void btnmul_Click(object sender, EventArgs e)
        {
            Allno mynum = new Allno();
            mynum.fristNum = Convert.ToInt32(TextBox1.Text.Trim());
            mynum.lastNum = Convert.ToInt32(TextBox2.Text.Trim());
            Mulfn(mynum);

        }
        Allno Mycal = new Allno();
        void Mulfn(Allno an)
        {
            Label1.Text = (an.fristNum * an.lastNum).ToString();
        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            Allno mynum = new Allno();
            mynum.fristNum = Convert.ToInt32(TextBox1.Text.Trim());
            mynum.lastNum = Convert.ToInt32(TextBox2.Text.Trim());
            Divfn(mynum);
        }
        Allno Mycs = new Allno();
        void Divfn(Allno an)
        {
            Label1.Text = (an.fristNum / an.lastNum).ToString();
        }
    }

    class Allno 
    {
    public int fristNum { get; set; }
    public int lastNum { get; set; }
    }
}