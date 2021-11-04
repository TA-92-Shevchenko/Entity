using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Post_Office
{
    class Program
    {
        static void Main(string[] args)
        { 

            
                using (PostOfficeContext db = new PostOfficeContext())
                {
                //add
               /*Person Person1 = new Person { Id = 12, ClientId = "Kolp", FirstName = "Ivan", LastName ="Ivanenko" };
               Person Person2 = new Person { Id = 17, ClientId = "5u8Ap", FirstName = "Ivan", LastName = "Mikolenko" };
                Person Person4 = new Person { Id = 5, ClientId = "jyU7u", FirstName = "Lisa", LastName = "Mikolenko" };
                Person Person5 = new Person { Id = 2, ClientId = "bbcfp", FirstName = "Ted", LastName = "Black" };
                db.People.Add(Person1);
                db.People.Add(Person2);
                db.People.Add(Person4);
                db.People.Add(Person5);
                db.SaveChanges();*/
                Console.WriteLine("Список объектов после добавления:");
                var persons = db.People.ToList();
                foreach (Person u in persons)
                {
                    Console.WriteLine($"{u.Id} {u.ClientId} {u.FirstName} {u.LastName}");
                }
               //delete
                /*
                Person person3 = db.People.FirstOrDefault();
                if (person3 != null)
                {
                   
                    db.People.Remove(person3);
                    db.SaveChanges();
                }
                db.People.Add(Person1);
                db.People.Add(Person2);
                db.People.Add(Person4);
                db.People.Add(Person5);
                db.SaveChanges();*/
                Console.WriteLine("Список объектов после удаления:");
                foreach (Person u in persons)
                {
                    Console.WriteLine($"{u.Id} {u.ClientId} {u.FirstName} {u.LastName}");
                }
                /*
                //Редактирование
                if (Person4 != null)
                {
                   Person1.FirstName = "Sam";
                   
                    db.People.Update(Person4);
                }
                db.People.Add(Person1);
                db.People.Add(Person2);
                db.People.Add(Person4);
                db.People.Add(Person5);
                db.SaveChanges();*/

                foreach (Person u in persons)
                {
                    Console.WriteLine($"{u.Id} {u.ClientId} {u.FirstName} {u.LastName}");
                }
               
                
                Console.WriteLine("Список объектов после редактирования:");
                foreach (Person u in persons)
                {
                    Console.WriteLine($"{u.Id} {u.ClientId} {u.FirstName} {u.LastName}");
                }
               

                var clients = db.Clients.ToList();
                    Console.WriteLine("Список клиентов:");
                    foreach (Client u in clients)
                    {
                        Console.WriteLine($"{u.Id} {u.ParcelId} {u.Email} {u.PhoneNumber}");
                    }
                }
                Console.ReadKey();

            }
    }
}