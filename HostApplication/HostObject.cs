using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostApplication
{
    class HostObject : MarshalByRefObject, RemotingObjects.IRemotingObject
    {
        private int c = 0;
        public string sayHello(string name)
        {
            c++;
            return "Hello " + name + " number of invocations : " + c.ToString();
        }
    }
}
