using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace demooo.Utils
{
    public class FileIO : System.Web.UI.Page
    {
        public string ReadFileJson(string filename)
        {
            FileStream fs = new FileStream(Server.MapPath(filename), FileMode.Open);
            StreamReader rd = new StreamReader(fs);
            string data = rd.ReadToEnd();
            rd.Close();
            fs.Close();
            return data;
        }
    }
}