using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class TractorBase
    {
        public TractorBase()
        {
            Tractor = new HashSet<Tractor>();
            TractorImage = new HashSet<TractorImage>();
        }

        public int TractorBaseId { get; set; }
        public string Name { get; set; }
        public string EngineMake { get; set; }
        public string EngineModel { get; set; }
        public string EngineType { get; set; }
        public string Aspiration { get; set; }
        public string EnginePowerkw { get; set; }
        public string MaxPowerEngineSpeedrpm { get; set; }
        public string MaxTorque { get; set; }
        public string MaxTorqueEngineSpeedrpm { get; set; }
        public string PtoPowerkw { get; set; }
        public string Displacementcm3 { get; set; }
        public string NoOfCylinders { get; set; }
        public string PtoSpeed { get; set; }
        public string FueltankCapacity { get; set; }
        public string PumpFlowStandardlpm { get; set; }
        public string PumpFlowOptionlpm { get; set; }
        public string LiftCapacitykg { get; set; }
        public string Drive { get; set; }
        public string TransmissionSpeeds { get; set; }
        public string Cab { get; set; }
        public string TyreSizeFront { get; set; }
        public string TyreSizeRear { get; set; }
        public string OverallLenghtmm { get; set; }
        public string StandardWidthmm { get; set; }
        public string HeightRopsmm { get; set; }
        public string HeightCabmm { get; set; }
        public string Wheelbasemm { get; set; }
        public string GroundClearancemm { get; set; }
        public string TrackWidthMinmm { get; set; }
        public string TrackWidthMaxmm { get; set; }
        public string TurningRadiusmm { get; set; }
        public string Weightkg { get; set; }
        public string TransmissionType { get; set; }
        public string DiffLock { get; set; }
        public int? SpecificationId { get; set; }
        public int? BrandId { get; set; }
        public int EntryTypeId { get; set; }

        public Brand Brand { get; set; }
        public EntryType EntryType { get; set; }
        public ListingFile Specification { get; set; }
        public ICollection<Tractor> Tractor { get; set; }
        public ICollection<TractorImage> TractorImage { get; set; }
    }
}
