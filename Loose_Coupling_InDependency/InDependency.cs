using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling_InDependency;
class MailSender
{
    public void SendMail(IMailServer mailServer)
    {
        mailServer.Send("filanca@falanca.com", "LayyHn");
    }
}
