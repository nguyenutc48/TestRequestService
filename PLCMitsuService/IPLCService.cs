using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCMitsuService
{
    public interface IPLCService
    {
        int getDeviceInt(string addr, out int data);
        int getDeviceInt32(string addr, out Int32 data);
    }
}
