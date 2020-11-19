using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ErrorMachineManagement
{
    public class MachineRequestModel
    {
        public string IP { get; set; }
        public NEasyTcp.Client.EasyTcpClient Client { get; set; }
        public Thread SendThread { get; set; }
    }
}
