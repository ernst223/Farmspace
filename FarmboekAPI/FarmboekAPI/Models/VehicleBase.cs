using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class VehicleBase
    {
        public VehicleBase()
        {
            Vehicle = new HashSet<Vehicle>();
            VehicleImage = new HashSet<VehicleImage>();
        }

        public int VehicleBaseId { get; set; }
        public string Name { get; set; }
        public string Range { get; set; }
        public string Model { get; set; }
        public string Segment { get; set; }
        public string Doors { get; set; }
        public string BodyShape { get; set; }
        public string EngineSizeLitre { get; set; }
        public string CylinderLayout { get; set; }
        public string Cylinders { get; set; }
        public string FuelType { get; set; }
        public string PowerMaximumTotal { get; set; }
        public string PowerPeakRevs { get; set; }
        public string TorquePeakRevs { get; set; }
        public string TorqueMaximumTotal { get; set; }
        public string TorqueMaximumDetail { get; set; }
        public string TorqueOverBoost { get; set; }
        public string TorqueOverBoostPeakRevs { get; set; }
        public string Acceleration0100kmh { get; set; }
        public string MaximumTopSpeed { get; set; }
        public string DrivenWheelsQuantity { get; set; }
        public string GearRatiosQuantity { get; set; }
        public string GearShift { get; set; }
        public string TransmissionType { get; set; }
        public int? BrandId { get; set; }
        public int EntryTypeId { get; set; }
        public int? SpecificationId { get; set; }

        public Brand Brand { get; set; }
        public EntryType EntryType { get; set; }
        public ListingFile Specification { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
        public ICollection<VehicleImage> VehicleImage { get; set; }
    }
}
