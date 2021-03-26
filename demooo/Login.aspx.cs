using demooo.Entity;
using demooo.Repository;
using demooo.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demooo
{
    public partial class Login : System.Web.UI.Page
    {
        UserRepository userRepository = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["user_login"] != null)
                Response.Redirect("/index.aspx");
            // khi co du lieu gui len server
            if (Request.RequestType.Equals("POST"))
            {
                string username = Request.Form["username"];
                string password = Request.Form["password"];
                UserEntity user = userRepository.FindUserByUsername(username);
                if (user != null && user.Password.Equals(password))
                {
                    Session.Add("user_login", user);
                    Response.Redirect("/Admin.aspx");
                }
                
            }
            
        }
    }
}