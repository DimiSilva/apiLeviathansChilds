using System;
using System.Collections.Generic;
using System.Linq;
using apiLeviathansChilds.domain.arguments.user;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.services;
using apiLeviathansChilds.domain.valueObjects;
using apiLeviathansChilds.infra.persistence;
using apiLeviathansChilds.infra.persistence.repositories;
using Npgsql;

namespace apiLeviathansChilds.tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var connString = "Server=ec2-107-21-120-104.compute-1.amazonaws.com;Port=5432;Database=d1qpflu2ge096f;User Id=hlijyndmgrwthy; Password=6b908ab41772f28cd4b524e49393930babfa93cd7965572dec93d8accb87e835;SSL Mode=Require;Trust Server Certificate=true;";
            RepositoryUser context = new RepositoryUser(connString);

            List<User> users;
            users = context.GetAll();
            users.ForEach(user => Console.WriteLine(user.name.firstName));

            // UpdateUserReq req = new UpdateUserReq();
            // req.id = Guid.Parse("1af0c01f-7e32-49b0-a487-93d4d7b040bd");
            // req.firstName = "Marcos";
            // req.lastName = "Machado";

            // User testUser = context.GetById(req.id);
            // Console.WriteLine(testUser.id.ToString());
            // testUser.Update(req);

            // Console.WriteLine(testUser.name.firstName);
            // Console.WriteLine(testUser.id.ToString());

            // if (testUser.IsValid())
            // {
            //     string user = context.Update(testUser).message;
            //     Console.WriteLine(user);
            // }
        }
    }
}
