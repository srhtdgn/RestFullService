﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestFullService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISunucu" in both code and config file together.
    [ServiceContract]
    public interface ISunucu
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [WebGet(RequestFormat =WebMessageFormat.Json,ResponseFormat =WebMessageFormat.Json)]
        string Yazdir();
    }
}
