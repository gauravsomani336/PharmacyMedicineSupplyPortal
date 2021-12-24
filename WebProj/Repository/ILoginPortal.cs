using WebProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProj.Repository
{
    public interface ILoginPortal
    {
        Task<string> UserRegistration(User user);
        Task<Authorize> GetToken(string name, string password);
    }
}
