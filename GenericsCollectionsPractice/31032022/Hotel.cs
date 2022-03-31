using _31032022.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022
{
    internal class Hotel
    {
        public string Name { get; set; }
        private List<Room> _rooms;

        public Room this[int index]
        {
            get => _rooms[index];
            set => _rooms[index] = value;
        }

        public Hotel(string name)
        {
            _rooms = new List<Room>();
            Name = name;
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
                throw new NullReferenceException("id null ola bilmez");

            foreach (var room in _rooms)
            {
                if (room.Id == roomId && !room.IsAvailable)
                    throw new NotAvailableException("rezerv olunub");
                else if(room.Id == roomId)
                    room.IsAvailable = false;
            }
        }

    }
}
