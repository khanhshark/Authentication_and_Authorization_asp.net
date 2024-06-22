using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Managerment.Service.Models;

namespace User.Managerment.Service.Services
{
    public interface IEmailServices
    {
        public void SendEmail(Message message);
       
        
    };
}
