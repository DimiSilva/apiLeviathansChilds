using System;
using System.Linq;
using apiLeviathansChilds.domain.arguments.user;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.services;
using apiLeviathansChilds.domain.valueObjects;
using apiLeviathansChilds.infra.persistence;

namespace apiLeviathansChilds.tests
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new Context())
            {
                context.Users.Add(new User(new RealName("teste", "teste"), "testando1", new Email("teste1@teste.com"), "123456"));
                context.SaveChanges();
                Console.WriteLine("inserido");
            }
            // Console.WriteLine("Tests starting...");

            // var service = new ServiceUser();
            // Console.WriteLine("Service instance created");

            // AuthenticationReq request = new AuthenticationReq();
            // Console.WriteLine("Request created");

            // request.firstName = "teste";
            // request.lastName = "testando";
            // request.emailAdress = "teste@teste.com";
            // request.password = "123456789";
            // request.nick = "teste";

            // var response = service.Authentication(request);

            // service.Notifications.ToList().ForEach(x => Console.WriteLine(x.Message));
        }
    }
}
