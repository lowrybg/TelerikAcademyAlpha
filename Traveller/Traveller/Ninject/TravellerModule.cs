using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Commands.Creating;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Factories;
using Traveller.Core.Providers;

namespace Traveller.Ninject
{
    public class TravellerModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IWriter>().To<ConsoleWriter>();
            this.Bind<IReader>().To<ConsoleReader>();
            this.Bind<IParser>().To<CommandParser>();

            this.Bind<ITravellerFactory>().To<TravellerFactory>().InSingletonScope();
            this.Bind<ICommandFactory>().To<CommandFactory>().InSingletonScope();

            this.Bind<IEngine>().To<Engine>().InSingletonScope();
            this.Bind<IDatabase>().To<Database>().InSingletonScope();

            this.Bind<ICommand>().To<ListJourneysCommand>().Named("listjourneys");
            this.Bind<ICommand>().To<ListTicketsCommand>().Named("listtickets");
            this.Bind<ICommand>().To<ListVehiclesCommand>().Named("listvehicles");

            this.Bind<ICommand>().To<CreateAirplaneCommand>().Named("CreateAirplaneInternal");
            this.Bind<ICommand>().To<CreateBusCommand>().Named("CreateBusInternal");
            this.Bind<ICommand>().To<CreateJourneyCommand>().Named("CreateJourneyInternal");
            this.Bind<ICommand>().To<CreateTicketCommand>().Named("CreateTicketInternal");
            this.Bind<ICommand>().To<CreateTrainCommand>().Named("CreateTrainInternal");
            


            this.Bind<ICommand>()
                .To<CreateAirplaneCommand>()
                .Named("createairplane")
                .WithConstructorArgument(this.Kernel.Get<ICommand>("CreateAirplaneInternal"));

            this.Bind<ICommand>()
                .To<CreateBusCommand>()
                .Named("createbus")
                .WithConstructorArgument(this.Kernel.Get<ICommand>("CreateBusInternal"));

            this.Bind<ICommand>()
                .To<CreateBusCommand>()
                .Named("createtrain")
                .WithConstructorArgument(this.Kernel.Get<ICommand>("CreateTrainInternal"));

            
            this.Bind<ICommand>()
                .To<CreateJourneyCommand>()
                .Named("createjourney")
                .WithConstructorArgument(this.Kernel.Get<ICommand>("CreateJourneyInternal"));

            this.Bind<ICommand>()
                .To<CreateTicketCommand>()
                .Named("createticket")
                .WithConstructorArgument(this.Kernel.Get<ICommand>("CreateTicketInternal"));

            
            
        }
    }
}
