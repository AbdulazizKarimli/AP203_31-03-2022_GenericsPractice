using _31032022.Exceptions;
using System;

namespace _31032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room()
            {
                Name = "sad",
                PersonCapacity = 5,
                Price = 23
            };
            Room room2 = new Room()
            {
                Name = "sad1",
                PersonCapacity = 5,
                Price = 24
            };


            Hotel hotel = new Hotel("test hotel");
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);

            try
            {
                hotel.MakeReservation(null);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            hotel[0].Name = "test";
            Console.WriteLine(hotel[0].Name);


        }
    }
}
