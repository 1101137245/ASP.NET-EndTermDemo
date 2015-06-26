using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    public class TicketDao : GenericDao<Ticket>, ITicketDao
    {
        override protected IRowMapper<Ticket> GetRowMapper()
        {
            return new TicketRowMapper();
        }

        public void AddTicket(Ticket ticket)
        {
            string command = @"INSERT INTO Ticket (Ticket_ID, Ticket_Name, Ticket_Quantity, Ticket_Date, Ticket_Time, Ticket_Aboard, Ticket_Getoff, Ticket_Number, Ticket_Phone, Ticket_Price) VALUES (@Id, @Name, @Quantity, @Date, @Time, @Aboard, @Getoff, @Number, @Phone, @Price);";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = ticket.Id;
            parameters.Add("Name", DbType.String).Value = ticket.Name;
            parameters.Add("Date", DbType.String).Value = ticket.Date;
            parameters.Add("Time", DbType.String).Value = ticket.Time;
            parameters.Add("Aboard", DbType.String).Value = ticket.Aboard;
            parameters.Add("Getoff", DbType.String).Value = ticket.Getoff;
            parameters.Add("Number", DbType.String).Value = ticket.Number;
            parameters.Add("Phone", DbType.String).Value = ticket.Phone;
            parameters.Add("Price", DbType.String).Value = ticket.Price;
            parameters.Add("Quantity", DbType.String).Value = ticket.Quantity;

            ExecuteNonQuery(command, parameters);
        }

        public void UpdateTicket(Ticket ticket)
        {
            string command = @"UPDATE Ticket SET Ticket_Name = @Name, Ticket_Quantity = @Quantity ,Ticket_Date = @Date, Ticket_Time = @Time, Ticket_Aboard = @Aboard, Ticket_Getoff = @Getoff, Ticket_Number = @Number, Ticket_Phone = @Phone, Ticket_Price = @Price WHERE Ticket_Id = @Id;";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = ticket.Id;
            parameters.Add("Name", DbType.String).Value = ticket.Name;
            parameters.Add("Quantity", DbType.String).Value = ticket.Quantity;
            parameters.Add("Date", DbType.String).Value = ticket.Date;
            parameters.Add("Time", DbType.String).Value = ticket.Time;
            parameters.Add("Aboard", DbType.String).Value = ticket.Aboard;
            parameters.Add("Getoff", DbType.String).Value = ticket.Getoff;
            parameters.Add("Number", DbType.String).Value = ticket.Number;
            parameters.Add("Phone", DbType.String).Value = ticket.Phone;
            parameters.Add("Price", DbType.String).Value = ticket.Price;

            ExecuteNonQuery(command, parameters);
        }

        public void DeleteTicket(Ticket ticket)
        {
            string command = @"DELETE FROM Ticket WHERE Ticket_Id = @Id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = ticket.Id;

            ExecuteNonQuery(command, parameters);
        }

        public IList<Ticket> GetAllTicket()
        {
            string command = @"SELECT * FROM Ticket ORDER BY Ticket_Id ASC";
            IList<Ticket> ticket = ExecuteQueryWithRowMapper(command);
            return ticket;
        }

        public Ticket GetTicketByName(string phone)
        {
            string command = @"SELECT * FROM Ticket WHERE Ticket_Phone = @phone";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Phone", DbType.String).Value = phone;

            IList<Ticket> ticket = ExecuteQueryWithRowMapper(command, parameters);
            if (ticket.Count > 0)
            {
                return ticket[0];
            }

            return null;
        }

        public Ticket GetTicketById(string id)
        {
            string command = @"SELECT * FROM Ticket WHERE Ticket_ID = @id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("id", DbType.String).Value = id;

            IList<Ticket> ticket = ExecuteQueryWithRowMapper(command, parameters);
            if (ticket.Count > 0)
            {
                return ticket[0];
            }

            return null;
        }
    }
}
