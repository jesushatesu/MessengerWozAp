using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceWCF
{
    public interface IServerChatCallback
    {
        [OperationContract(IsOneWay = true)]
        void MsgCallback(string fromUser, string toUser, string msg);

        [OperationContract(IsOneWay = true)]
        void ConnectUserCallback(string userName);

        [OperationContract(IsOneWay = true)]
        void DisconnectUserCallback(string userName);
    }
}
