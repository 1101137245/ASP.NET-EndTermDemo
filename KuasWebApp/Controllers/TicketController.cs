using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace KuasWebApp.Controllers
{
    public class TicketController : ApiController
    {

        public ITicketService TicketService { get; set; }

        [HttpPost]
        public Ticket AddTicket(Ticket ticket)
        {
            CheckTicketIsNotNullThrowException(ticket);

            try
            {
                return TicketService.AddTicket(ticket);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpPut]
        public Ticket UpdateTicket(Ticket ticket)
        {
            CheckTicketIsNullThrowException(ticket);

            try
            {
                TicketService.UpdateTicket(ticket);
                return TicketService.GetTicketByName(ticket.Name);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete]
        public void DeleteEmployee(Ticket ticket)
        {
            try
            {
                TicketService.DeleteTicket(ticket);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public IList<Ticket> GetAllTicket()
        {
            return TicketService.GetAllTicket();
        }

        [HttpGet]
        public Ticket GetTicketById(string id)
        {
            var ticket = TicketService.GetTicketById(id);

            if (ticket == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return ticket;
        }

        [HttpGet]
        [ActionName("Name")]
        public Ticket GetTicketByName(string input)
        {
            var ticket = TicketService.GetTicketByName(input);

            if (ticket == null)
            {

                return null;
                // throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return ticket;
        }

        /// <summary>
        ///     檢查課程資料是否存在，如果不存在則拋出錯誤.
        /// </summary>
        /// <param name="ticket">
        ///     課程資料.
        /// </param>
        private void CheckTicketIsNullThrowException(Ticket ticket)
        {
            Ticket Ticket = TicketService.GetTicketById(ticket.Id);

            if (Ticket == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        ///     檢查課程資料是否存在，如果存在則拋出錯誤.
        /// </summary>
        /// <param name="ticket">
        ///     課程資料.
        /// </param>
        private void CheckTicketIsNotNullThrowException(Ticket ticket)
        {
            Ticket dbTicket = TicketService.GetTicketById(ticket.Id);

            if (dbTicket != null)
            {
                throw new HttpResponseException(HttpStatusCode.Conflict);
            }
        }

    }
}