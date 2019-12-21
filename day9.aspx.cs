using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteUI
{
    public partial class day9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }
        
        public string Name() {


            return "U ba";
        }
        public string title()
        {
            return "welcome to";
        }
        public void lst()
        {
            lblname.InnerText = txtid.12
                
                text.Trim() + "-" + title() + Name;
        }

        protected void btmsave_Click(object sender, EventArgs e)
        {
            lst();
        }
    }
}