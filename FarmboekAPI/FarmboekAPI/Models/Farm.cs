using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Farm
    {
        public int FarmId { get; set; }
        public string FarmName { get; set; }
        public string Muncipality { get; set; }
        public string PropertySize { get; set; }
        public int FarmNumber { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string NearestTown { get; set; }
        public string Description { get; set; }
        public int AddPrimary { get; set; }
        public int PrimaryBedrooms { get; set; }
        public int PrimaryBathrooms { get; set; }
        public string PrimaryInfo { get; set; }
        public int AddSecondary { get; set; }
        public int SecondaryBedrooms { get; set; }
        public int SecondaryBathrooms { get; set; }
        public string SecondaryInfo { get; set; }
        public int AddWorkers { get; set; }
        public int WorkersBedrooms { get; set; }
        public int WorkersBathrooms { get; set; }
        public string WorkersInfo { get; set; }
        public int FarmImageId { get; set; }
        public int WaterRightsId { get; set; }
        public int InfrastructureId { get; set; }
        public int UserId { get; set; }
        public double PriceIncVat { get; set; }
        public double PriceExclVat { get; set; }
        public int? RouteRouteId { get; set; }

        public Infrastructure Infrastructure { get; set; }
        public Route RouteRoute { get; set; }
        public WaterRights WaterRights { get; set; }
    }
}
