using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace handin_3
{
    public partial class Sessions : System.Web.UI.Page
    {
        ArrayList listOfStaff = new ArrayList();
        ArrayList listOfMagic = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["listOfStaff"] == null)
            {
                Application["listOfStaff"] = listOfStaff;
            }

            if (Application["listOfMagic"] == null)
            {
                Application["listOfMagic"] = listOfMagic;
            }
        }

        public void OnLogin (object sender, EventArgs e)
        {
            for (int i = 0; i < listOfStaff.Count; i++)
            {
                Staff staffMember = (Staff)listOfStaff[i];
                bool isAuth = staffMember.IsAuth(NameInput.Text, PasswordInput.Text);

                if (isAuth)
                {
                    Response.Redirect("Profile.aspx");
                    return;
                } else
                {
                    ErrMessage.Text = "Incorrect login";
                }
            }

            for (int i = 0; i < listOfMagic.Count; i++)
            {
                Magician magicMember = (Magician)listOfMagic[i];
                bool isAuth = magicMember.IsAuth(NameInput.Text, PasswordInput.Text);

                if (isAuth)
                {
                    Response.Redirect("Profile.aspx");
                    return;
                } else
                {
                    ErrMessage.Text = "Incorrect login";
                }
            }
        }
    }
}