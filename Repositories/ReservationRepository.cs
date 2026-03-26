using Dapper;
using HotelManagementSystem.Context.FrontendReservation;
using HotelManagementSystem.Data;
using HotelManagementSystem.Entities.FrontendReservation;
using HotelManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        FrontendReservationContext Context = new FrontendReservationContext();

        //EF Core

        public int Create(Reservation reservation)
        {
            Context.Add(reservation);
            Context.SaveChanges();
            return reservation.Id;
        }

        public void Update(Reservation reservation)
        {
            var existing = Context.Reservations.Find(reservation.Id);
            if (existing==null) throw new InvalidOperationException($"Reservation {reservation.Id} Not valid");
            Context.Entry(existing).CurrentValues.SetValues(reservation);
            //Context.Reservations.Update(reservation);
            Context.SaveChanges();
        }
        public void Delete(int id)
        {
            var existing = Context.Reservations.Find(id);
            if (existing == null) return;
            Context.Reservations.Remove(existing);
            Context.SaveChanges();
        }


        //Dapper
        public IEnumerable<Reservation> GetAllReservations()
        {
            using var conn = DbConnectionFactory.GetFrontendConnection();
            var res = conn.Query<Reservation>("""
                select * from reservations
                """);
            return res;
        }

        public Reservation? GetById(int id)
        {
            using var conn = DbConnectionFactory.GetFrontendConnection();
            var res = conn.QueryFirstOrDefault<Reservation>("""
                select * from reservations where id=@id
                """, new {id});
            return res;
        }

        public IEnumerable<string> GetCheckedInRoomNumbers()
        {
            using var conn = DbConnectionFactory.GetFrontendConnection();
            var res = conn.Query<string>("""
                select roomnumber from reservations where checkin=1
                """);
            return res;
        }

        public IEnumerable<Reservation> GetKitchenList()
        {
            using var conn = DbConnectionFactory.GetFrontendConnection();
            var res = conn.Query<Reservation>(
                """
                select * from reservations where checkin=1 and supplystatus=0
                """);
            return res;
        }

        public IEnumerable<Reservation> GetKitchenQueue()
        {
            using var conn = DbConnectionFactory.GetFrontendConnection();
            var res = conn.Query<Reservation>("""
                Select id, firstname, lastname, phonenumber
                from reservations where checkin=1 and supplystatus=0
                """);
            return res;
        }

        public IEnumerable<Reservation> GetOccupied()
        {
            using var conn = DbConnectionFactory.GetFrontendConnection();
            var res = conn.Query<Reservation>("""
                select * from reservations where supplystatus=0
                """);
            return res;
        }

        public IEnumerable<Reservation> GetReserved()
        {
            using var conn = DbConnectionFactory.GetFrontendConnection();
            var res = conn.Query<Reservation>("""
                select * from reservations where checkin=0
                """);
            return res;
        }

        public IEnumerable<Reservation> Search(string term)
        {
            using var conn = DbConnectionFactory.GetFrontendConnection();
            var param = $"%{term}%";
            var res = conn.Query<Reservation>("""
                select * from reservations where
                cast(id as nvarchar) like @param
                OR firstname like @param
                OR lastname like @param
                OR Gender like @param
                OR State like @param
                OR City like @param
                OR Roomnumber like @param
                OR Roomtype like @param
                OR emailaddress like @param
                OR phonenumber like @param
                """, new { param });
            return res;
        }

    }
}
