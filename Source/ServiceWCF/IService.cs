using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MainWindow;

namespace ServiceWCF
{
    [ServiceContract(CallbackContract = typeof(IServerChatCallback))]   
    public interface IService
    {
        [OperationContract]
        string[] Connect(string userName);

        [OperationContract]
        void Disconnect(string userName);

		[OperationContract(IsOneWay = true)]
        void SendMsg(string fromUserName, string toUserName, string msg);

        [OperationContract]
        string[] GetUnsentMsg(string userNameFrom, string userNameTo);
    }
}
