using EnjoyEatCore.Dao;
using EnjoyEatCore.Models;
using EnjoyEatCore.Services.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCoreTests.Dao
{
    [TestClass]
    public class TicketDaoUnitTest : AbstractDependencyInjectionSpringContextTests
    {

        #region Spring 單元測試必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCorePointcut.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        public ITicketDao TicketDao { get; set; }


        [TestMethod]
        public void TestTicketDao_AddTicket()
        {
            Ticket ticket = new Ticket();
            ticket.Id = "09XXXXXXXX-2999/13/3325:61:62";
            ticket.Name = "單元測試";
            ticket.Phone = "09XXXXXXXX";
            ticket.Quantity = "X張";
            ticket.Date = "2999/13/33";
            ticket.Time = "25:61:62";
            ticket.Aboard = "金門";
            ticket.Getoff = "馬祖";
            ticket.Number = "1000";
            ticket.Price = "50000";
            TicketDao.AddTicket(ticket);

            Ticket dbTicket = TicketDao.GetTicketByName(ticket.Phone);
            Assert.IsNotNull(dbTicket);
            Assert.AreEqual(ticket.Name, dbTicket.Name);

            Console.WriteLine("訂票編號為 = " + dbTicket.Id);
            Console.WriteLine("訂票人為 = " + dbTicket.Name);
            Console.WriteLine("手機為 = " + dbTicket.Phone);
            Console.WriteLine("訂票數量為 = " + dbTicket.Quantity);
            Console.WriteLine("乘車日期為 = " + dbTicket.Date);
            Console.WriteLine("乘車時間為 = " + dbTicket.Time);
            Console.WriteLine("上車站為 = " + dbTicket.Aboard);
            Console.WriteLine("下車站為 = " + dbTicket.Getoff);
            Console.WriteLine("車次為 = " + dbTicket.Number);
            Console.WriteLine("總金額為 = " + dbTicket.Price);

           /* TicketDao.DeleteTicket(dbTicket);
            dbTicket = TicketDao.GetTicketByName(ticket.Phone);
            Assert.IsNull(dbTicket);*/
        }

    }
}
