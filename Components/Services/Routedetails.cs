using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using octisv2.Components.Data;
using octisv2.Components.Hubs;
using System.Net.NetworkInformation;
using Microsoft.Identity.Client.TelemetryCore.TelemetryClient;
using octisv2.Components.Pages;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;


namespace octisv2.Components.Services
{
    public class Routedetails
    {
        //private readonly IHubContext<RoutedHub> _context;
        //private readonly string _connectionstring;
        AppDb DbContext = new AppDb();
       // private readonly SqlTableDependency<Routed> _sub;
        

      /*
        public Routedetails(IHubContext<RoutedHub> context) {
            _context = context;
            _connectionstring = "Server=tcp:mastransport.database.windows.net,1433;Initial Catalog=MASTranspory;Persist Security Info=False;User ID=CloudSA972ca15a;Password=Dakshina@123@345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; 
            _sub = new SqlTableDependency<Routed>(_connectionstring, "Routed");
            _sub.OnChanged += Changed;
            _sub.Start();
        }
      

        private async void Changed(object sender, RecordChangedEventArgs<Routed> e)
        {
            var Routed = await Getallroutes();
            await _context.Clients.All.SendAsync("RefreshRoutes", Routed);
        }

        //get all records Routed

        /*
        public async Task<List<Routed>> getalldriver()
        {
            return await DbContext.DriverPool.AsNoTracking().ToListAsync();
        }
        */
        public async Task<List<Routed>> Getallroutes()
        {

            return await DbContext.Routed.AsNoTracking().ToListAsync();

        }

        //get all records Seatcap
        public async Task<List<SeatCap>> Getalldetails()
        {
            return await DbContext.SeatCap.AsNoTracking().ToListAsync();
        }

        //add the new routed details
        public async Task<bool> AddNewRouted(Routed Routed)
        { 
            await DbContext.Routed.AddAsync(Routed);
            await DbContext.SaveChangesAsync();
            return true;
        }

        /*
         *  public async Task<Routed> GetRoutedbyId(int epf)
        {

            Routed routed = await DbContext.Routed.FirstOrDefaultAsync(x => x.EPF == epf);

            return routed!;
        }
         */
        //Get Routed Records by EPF


        //Get Routed Records by Shift
        /*
         *   public async Task<Routed> GetRoutedbyshift(string shift)
        {

            Routed routed = await DbContext.Routed.FirstOrDefaultAsync(x => x.Shift == shift);

            return routed!;

        }
         */

        // Get Setavailability by routnumber
        /*
         *   public async Task<SeatCap> GetRoutedbyRnt(string routes)
         {

             //SeatCap seatCap = await DbContext.SeatCap.FirstOrDefaultAsync(x => x.RouteNumber == routes);

            // return seatCap!;

         }
         */



        // Update the Routed
        public async Task<bool> UpdateRouted(Routed? Routed)
        {
            DbContext.Routed.Update(Routed!); 
            await DbContext.SaveChangesAsync();
            return true;
        }
        // Delete the Routed
        public async Task<bool> DeleteRouted(Routed? Routed)
        {
            DbContext.Routed.Remove(Routed!);
            await DbContext.SaveChangesAsync();
            return true;
        }

        //GetDataMNroutes
        public async Task<List<MNroutes>> GetMNroutes()
        {
            return await DbContext.NMNroutes.AsNoTracking().ToListAsync();

        }
        //GetDataDriverpool
        public async Task<List<DriverPool>> GetallDriver()
        {
            return await DbContext.DriverPool.AsNoTracking().ToListAsync();
        }


    }



}