using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRTest.Models
{
    public interface ITypeOfClient
    {
        Task SendAsync(string name, string user, string message);
    }
}
