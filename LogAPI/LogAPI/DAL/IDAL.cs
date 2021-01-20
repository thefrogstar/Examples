using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogAPI.Models;

namespace LogAPI
{
    interface IDAL
    {
        void LogMessage(LogMessage message);
    }
}