using System;
using System.Collections.Generic;

namespace Reservations
{
    class ReservationApp
    {
        static void Main(string[] args)
        {
            var myReservations = GenerateReservationList(10);

            PrintReservations(myReservations);
        }

        public static List<Reservation> GenerateReservationList(int quantity)
        {
            List<Reservation> reservationList = new List<Reservation>();

            for (int i = 0; i < quantity; i++)
            {
                reservationList.Add(new Reservation());
            }
            return reservationList;
        }

        public static void PrintReservations(List<Reservation> reservations)
        {
            foreach (var reservation in reservations)
            {
                Console.WriteLine($"Booking #{reservation.ReservationNumber} for {reservation.ReservationDay}");
            }
        }
    } 
}
