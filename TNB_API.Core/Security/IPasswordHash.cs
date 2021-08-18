using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNB_API.Core.Security
{
    public interface IPasswordHash
    {
        string HashPassword(string password);
        string GenerateTempKey();
        bool ValidatePassword(string password, string correctHash);
    }
}
