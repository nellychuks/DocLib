using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocLib.Domain.Interface.Utilities
{
    public interface IEncryption
    {
        string Encrypt(string plainText);
    }
}
