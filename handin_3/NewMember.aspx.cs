using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace handin_3
{
    public partial class NewMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application["listOfMagic"] = new ArrayList();
            Application["listOfStaff"] = new ArrayList();
        }

        protected void OnRegisterMagic (object sender, EventArgs e)
        {
            Magician magician = new Magician(TrickInput.Text, NameInput.Text, PasswordInput.Text);

            ArrayList listOfMagicians = (ArrayList)Application["listOfMagic"];
            listOfMagicians.Add(magician);

            Application["listOfMagic"] = listOfMagicians;
            Response.Redirect("Sessions.aspx");
        }

        protected void OnRegisterStaff(object sender, EventArgs e)
        {
            Magician staff = new Magician(SalaryInput.Text, NameInput.Text, PasswordInput.Text);

            ArrayList listOfStaff = (ArrayList)Application["listOfStaff"];
            listOfStaff.Add(staff);

            Application["listOfMagic"] = listOfStaff;
            Response.Redirect("Sessions.aspx");
        }
    }
}