using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Collections.ObjectModel;
using System.Collections.Generic;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Microsoft.Health;
using Microsoft.Health.Web;
using Microsoft.Health.ItemTypes;
using Microsoft.Health.PatientConnect;
using Microsoft.Health.Authentication;
using Microsoft.Health.Web.Authentication;
using Microsoft.Health.Package;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        _Default connect = new _Default();
        connect.CreateConnectRequest("Marcus", "Graduate school", "Georgia Tech", "101");
    }
}

public partial class _Default : HealthServicePage
{
    public void CreateConnectRequest(
    string friendlyName,
    string secretQuestion,
    string secretAnswer,
    string patientId)
    {
        try {
             // Create an offline connection
            string healthServiceUrl = "https://platform.healthvault-ppe.com/platform/";
            OfflineWebApplicationConnection connection = new OfflineWebApplicationConnection(ApplicationId, healthServiceUrl,
                Guid.Empty /* offlinePersonId */);

            PatientConnection.DeletePending(connection, patientId);
            
            // Create the connect request

            string code = PatientConnection.Create(
                connection,
                friendlyName,
                secretQuestion,
                secretAnswer,
                null /* callbackUrl -- not implemented */,
                patientId);

           
            //Send mail with the unique code to enter in the healthvault

            System.Web.Mail.MailMessage message = new System.Web.Mail.MailMessage();
            message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", 1);
            message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "gaurav@hisp.i3l.gatech.edu");
            message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "001");
            message.From = "gaurav@hisp.i3l.gatech.edu";
            message.Subject = "Healthvault shell";
            message.To = "marcus.walker9206@direct.healthvault-ppe.com";
            message.Body = code;
            System.Web.Mail.SmtpMail.SmtpServer = "hisp.i3l.gatech.edu";
            System.Web.Mail.SmtpMail.Send(message);

            this.RedirectToShellUrl("CONNECT", "appid=" + this.ApplicationId.ToString() + "&ismra=true");
        }
        catch { }
        
    }

 }