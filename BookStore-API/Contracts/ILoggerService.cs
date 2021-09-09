using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Contracts
{
    // The general convention for naming an interface is to put I at the beginning
    public interface ILoggerService
    {
        void LogInfo(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);
    }
}
