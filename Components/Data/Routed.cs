using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using GoogleApi.Entities.Common;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace octisv2.Components.Data
{
    public class Routed
    {
        [Key]
        public int  EPF { get; set; }
        public String Name { get; set; }
        public String Shift { get; set; }
        public String Contact { get; set; }
        public String NIC { get; set; }
        public String Gender { get; set; }
        public String  VSM { get; set; }
    }


    public class SeatCap
    {
        public string? RouteNumber { get; set; }
        public string? Shift { get; set; }
        public string? DriverName { get; set; }
        public string? NIC { get; set; }
        public int? Mobile { get; set; }
        public int? SeatingCapacity { get; set; }
        public int? Occupancy { get; set; }
        public int? Availability { get; set; }

    }

    public class MNroutes
    {
        public string? RouteNo { get; set; }
        public string? Contractor { get; set; }
        public string? Shift { get; set; }
        public string? VehcleType { get; set; }
        public float? Distance{ get; set; }
        public int? SeatCapacity { get; set; }
        public int? Occupancy { get;set; }
        public int? Availability { get; set;}
        public int? Occupancyop { get;set; }
        public string? RouteDiscription { get; set; }
        public string? MobileNo{ get;set; }



    }
    
    public class DriverPool
    {
        
        
        public int EPF { get; set; }
        public string? Name { get; set; }
        public  string? IDNo { get; set; }
        public string? BDay { get; set; }
        public string? Address { get; set; }
        public int? landNo { get; set; }
        public int? cellNo { get; set; }
        public string? DLNo { get; set; }


    }
}