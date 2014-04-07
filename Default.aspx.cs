/********************************************************************++

Copyright (c) Microsoft Corporation. All rights reserved.

************************************************************************/

using System;
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

//public partial class _Default : HealthServicePage
//{
//    private void CreateConnectRequest(
//    string friendlyName,
//    string secretQuestion,
//    string secretAnswer,
//    string patientId)
//    {
//        // Create an offline connection
//        string healthServiceUrl = "https://www.healthvault-ppe.com/";
//        OfflineWebApplicationConnection connection = new OfflineWebApplicationConnection(ApplicationId,healthServiceUrl,
//            Guid.Empty /* offlinePersonId */);

//        // Create the connect request
//        string code = PatientConnection.Create(
//            connection,
//            friendlyName,
//            secretQuestion,
//            secretAnswer,
//            null /* callbackUrl -- not implemented */,
//            patientId);

//        // Email the URL and code to the user
//        //SendConnectRequestMail(patientId, code);
//    }
//}


