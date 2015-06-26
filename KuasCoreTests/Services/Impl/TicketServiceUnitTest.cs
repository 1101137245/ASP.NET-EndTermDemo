using Core;
using KuasCore.Models;
using KuasCore.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Context;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCoreTests.Services.Impl
{
    [TestClass]
    public class TicketServiceUnitTest : AbstractDependencyInjectionSpringContextTests
    {

        #region Spring 單元測試必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    //assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCorePointcut.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        public ITicketService TicketService { get; set; }

        [TestMethod]
        public void TestTicketService_AddTicket()
        {

            Ticket ticket = new Ticket();
            ticket.Id = "09XXXXXXXO-2999/13/3225:61:61";
            ticket.Name = "單元測試2";
            ticket.Phone = "09XXXXXXXO";
            ticket.Quantity = "X張";
            ticket.Date = "2999/13/32";
            ticket.Time = "25:61:61";
            ticket.Aboard = "金門";
            ticket.Getoff = "馬祖";
            ticket.Number = "1000";
            ticket.Price = "50000";

            TicketService.AddTicket(ticket);

            Ticket dbTicket = TicketService.GetTicketByName(ticket.Phone);
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

            /*
            TicketService.DeleteTicket(dbTicket);
            dbTicket = TicketService.GetTicketByName(ticket.Phone);
            Assert.IsNull(dbTicket);*/
        }

    }
}
