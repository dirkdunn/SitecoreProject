using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;
using Sitecore;
using Sitecore.Shell.Applications.ContentEditor;
using Sitecore.Web;
using Sitecore.Web.UI.Sheer;
using System;

namespace SitecoreDev.Web.Custom.Fields
{
    public class CreditCard : Password
    {
        private string _creditCardRegEx = @"^\d{4}([\-]?)\d{4}\1\d{4}\1\d{4}$";
        public CreditCard()
        {
            Console.WriteLine("CreditCard()");
            Class = "scContentControl";
        }
        public override void HandleMessage(Message message)
        {
            Console.WriteLine("HandleMessage()");
            base.HandleMessage(message);
            if (message.Name == "creditcard:validate")
            {
                string currentvalue = WebUtil.GetFormValue(ID);
                string result = Regex.IsMatch(
                currentvalue, _creditCardRegEx) ? "Valid" : "Invalid";
                SheerResponse.SetStyle("validationResult_" + ID, "color", "red");
                SheerResponse.SetInnerHtml("validationResult_" + ID, result);
            }
        }
        protected override void OnPreRender(System.EventArgs e)
        {
            Console.WriteLine("OnRender()");
            base.OnPreRender(e);
            ServerProperties["Value"] = ServerProperties["Value"];
        }
        protected override void Render(System.Web.UI.HtmlTextWriter output)
        {
            Console.WriteLine("Render()");
            base.Render(output);

            HtmlGenericControl formatHtml = new HtmlGenericControl("div");
            formatHtml.Attributes.Add("style", "color:#888888;");
            formatHtml.InnerHtml = "xxxx-xxxx-xxxx-xxxx";
            formatHtml.RenderControl(output);

            HtmlGenericControl validationHtml = new HtmlGenericControl("div");
            validationHtml.Attributes.Add("ID", "validationResult_" + ID);
            validationHtml.Attributes.Add("style", "color:#888888;");
            validationHtml.InnerHtml = "";
            validationHtml.RenderControl(output);
        }
        protected override bool LoadPostData(string value)
        {
            Console.WriteLine("LoadPostData()");
            value = StringUtil.GetString(new string[1] { value });
            if (!(Value != value))
                return false;
            Value = value;
            base.SetModified();
            return true;
        }
    }
}