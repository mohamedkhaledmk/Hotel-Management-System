using HotelManagementSystem.Entities.FrontendReservation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Repositories.Interfaces
{
    public interface IReservationRepository
    {
        //EF Part
        int Create(Reservation reservation);
        void Update(Reservation reservation);
        void Delete(int id);

        //Dapper Part
        IEnumerable<Reservation> GetAllReservations();
        Reservation? GetById(int id);
        IEnumerable<Reservation> GetOccupied();
        IEnumerable<Reservation> GetReserved();
        IEnumerable<string> GetCheckedInRoomNumbers();
        IEnumerable<Reservation> Search(string term);
        IEnumerable<Reservation> GetKitchenQueue();
        IEnumerable<Reservation> GetKitchenList();

    }
}
