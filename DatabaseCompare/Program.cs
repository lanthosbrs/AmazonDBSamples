using System;
using DatabaseCompare.ArouraDB;
using DatabaseCompare.DynamoExample;


namespace DatabaseCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Lets do this");

            //var temp = new DynamoDBExample();

            //Console.WriteLine("Adding user 1");
            //var userAdd1 =  temp.AddAUserAsync();
            //userAdd1.Wait();
            //var userId1 = userAdd1.Result;
            //Console.WriteLine($"User 1 id : {userId1}");

            //Console.WriteLine("Adding user 2");
            //var userAdd2 = temp.AddAUserAsync();
            //userAdd2.Wait();
            //var userId2 = userAdd2.Result;
            //Console.WriteLine($"User 2 id : {userId2}");

            //Console.WriteLine("Adding user 3");
            //var userAdd3 = temp.AddAUserAsync();
            //userAdd3.Wait();
            //var userId3 = userAdd3.Result;
            //Console.WriteLine($"User 4 id : {userId3}");


            //Console.WriteLine("Getting user 1");
            //var userGet = temp.GetAUserAsync(userId1);
            //userGet.Wait();
            //var user1 = userGet.Result;
            //Console.WriteLine($"Got user {user1.Name}");

            //Console.ReadLine();

            Console.WriteLine("Ok Aroura time");

            var tempA = new ArouraDBExample();

            Console.WriteLine("Adding user 1");
            var aUserAdd1 = tempA.AddAUser();
            Console.WriteLine($"User 1 id : {aUserAdd1}");

            Console.WriteLine("Adding user 2");
            var aUserAdd2 = tempA.AddAUser();
            Console.WriteLine($"User 2 id : {aUserAdd2}");

            Console.WriteLine("Adding user 3");
            var aUserAdd3 = tempA.AddAUser();
            Console.WriteLine($"User 3 id : {aUserAdd3}");

            Console.WriteLine("Adding user 4");
            var aUserAdd4 = tempA.AddAUser();
            Console.WriteLine($"User 1 id : {aUserAdd4}");
            

            Console.WriteLine("Getting user 1");
            var aUser1 = tempA.GetAUser(aUserAdd1);
            Console.WriteLine($"Got user {aUser1.Name}");

            Console.ReadLine();


        }
    }
}
