using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core.Providers
{
   

    public class Database : IDatabase
    {

        private readonly List<IJourney> journey;
        private readonly List<ITicket> ticket;
        private readonly List<IVehicle> vehicle;

        public Database()
        {
            this.journey = new List<IJourney>();
            this.ticket = new List<ITicket>();
            this.vehicle = new List<IVehicle>();
        }


        public IList<IJourney> Journey
        {
            get
            {
                return this.journey;
            }
        }

        public IList<ITicket> Ticket
        {
            get
            {
                return this.ticket;
            }
        }

        public IList<IVehicle> Vehicle
        {
            get
            {
                return this.vehicle;
            }
        }
    }
}
