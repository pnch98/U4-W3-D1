using System;
using System.Configuration;
using System.Web.UI;

namespace EsercizioD1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ShowName(object sender, EventArgs e)
        {
            parag.InnerHtml = ConfigurationManager.AppSettings["name"] + " " + ConfigurationManager.AppSettings["surname"];
        }
    }
}