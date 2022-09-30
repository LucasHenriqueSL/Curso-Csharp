using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeExeption.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn); // diferença de datas checkout - checkin

            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room" + RoomNumber + ", check-in: " + CheckIn.ToString("dd/mm/yyyy") + ", check-out: " + CheckOut.ToString("dd/mm/yyyy") + ", " + Duration() + "nights";
        }
    }
}
