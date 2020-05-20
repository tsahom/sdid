using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostApplication
{
    class HostObject : MarshalByRefObject, RemotingObjects.IRemotingObject
    {
        public string sayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
