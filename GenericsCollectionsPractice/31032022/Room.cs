using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022
{
    internal class Room
    {
        private static int _id;

        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Room()
        {
            _id++;
            Id = _id;
        }

        public string ShowInfo()
        {
            return $"Id: {Id} - Name: {Name} - Price: {Price} - PersonCapacity: {PersonCapacity} - IsAvailable: {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
