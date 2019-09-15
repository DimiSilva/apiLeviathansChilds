using System;
using System.Linq;
using apiLeviathansChilds.domain.arguments.user;
using apiLeviathansChilds.domain.services;

namespace apiLeviathansChilds.tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tests starting...");

            var service = new ServiceUser();
            Console.WriteLine("Service instance created");

            AuthenticationReq request = new AuthenticationReq();
            Console.WriteLine("Request created");

            request.emailAdress = "teste@teste.com";
            request.password = "123456789";
            request.nick = "teste";

            var response = service.Authentication(request);

            service.Notifications.ToList().ForEach(x => Console.WriteLine(x.Message));
        }
    }
}
