using System;
using System.Collections.Generic;

namespace Reservations
{
    public class Reservation : IReservation
    {
        public string ReservationNumber { get; private set; }
        public string ReservationDay { get; private set; }

        public Reservation()
        {
            ReservationDay = GetDowBooking();
            ReservationNumber = GetCodeBooking();
        }

        public string GetDowBooking()
        {
            string[] days = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
            int dayOfWeek = new Random().Next(7);
            return days[dayOfWeek];
        }

        public string GetCodeBooking()
        {
            string resNumber = "";
            string charactersToUse = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            for (int i = 0; i < 8; i++)
            {
                resNumber = resNumber + charactersToUse[new Random().Next(0, charactersToUse.Length)];
            }
            return resNumber;
        }
    }
}
