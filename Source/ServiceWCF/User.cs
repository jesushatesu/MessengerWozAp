using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceWCF
{
    public struct User
    {
        public string Name { get; set; }
		public bool isConnected;
        public OperationContext opCont { get; set; }

		public void ChangeCon(bool val)
		{
			isConnected = val;
		}
    }
}
