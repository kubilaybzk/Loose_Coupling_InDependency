namespace Loose_Coupling_InDependency;

interface IMailServer
{
    void Send(string to, string body);
}
