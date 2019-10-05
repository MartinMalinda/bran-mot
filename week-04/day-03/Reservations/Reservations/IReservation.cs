using System;
namespace Reservations
{
    public interface IReservation
    {
        string GetDowBooking();
        string GetCodeBooking();
    }
}
