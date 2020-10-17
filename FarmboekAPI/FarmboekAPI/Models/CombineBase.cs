using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class CombineBase
    {
        public CombineBase()
        {
            Combine = new HashSet<Combine>();
            CombineImage = new HashSet<CombineImage>();
        }

        public int CombineBaseId { get; set; }
        public int EntryTypeId { get; set; }
        public int? BrandId { get; set; }
        public string Name { get; set; }
        public string EngineMake { get; set; }
        public string EngineModel { get; set; }
        public string EngineType { get; set; }
        public string Aspiration { get; set; }
        public string EnginePowerkW { get; set; }
        public string MaxPowerEngineSpeedrpm { get; set; }
        public string Displacementcm3 { get; set; }
        public string NoOfCylinders { get; set; }
        public string FueltankCapacitylitres { get; set; }
        public string Transmission { get; set; }
        public string GroundSpeed1stkmPerh { get; set; }
        public string GroundSpeed2ndkmPerh { get; set; }
        public string GroundSpeed3rdkmPerh { get; set; }
        public string GroundSpeed4thkmPerh { get; set; }
        public string AutoHeaderHeightControl { get; set; }
        public string LateralFloat { get; set; }
        public string AutoFloat { get; set; }
        public string ReelAndPickupDrive { get; set; }
        public string ThreshingSystem { get; set; }
        public string ThreshingConcavesWrapAngle { get; set; }
        public string ThreshingConcavesWrapAngleExtension { get; set; }
        public string ThreshingConcavesAdjustment { get; set; }
        public string SeperationConcavesGratesPerRotor { get; set; }
        public string SeperationConcavesWrapAngel { get; set; }
        public string DischargeBeater { get; set; }
        public string TotalSeperationAream2 { get; set; }
        public string SelfLevelingShoe { get; set; }
        public string PreCleaningSystem { get; set; }
        public string RemoteSieveSettings { get; set; }
        public string ShoeSystem { get; set; }
        public string SieveAream2 { get; set; }
        public string CleaningFanSpeedrpm { get; set; }
        public string GrainTankCapacitylitres { get; set; }
        public string UnloadingTubeLengthm { get; set; }
        public string UnloadingTubeLengthExtm { get; set; }
        public string UnloadingSpeedlitersPersec { get; set; }
        public string TyreSizeFront { get; set; }
        public string TyreSizeRear { get; set; }
        public string OverallLenghtm { get; set; }
        public string StandardWidthm { get; set; }
        public string HeightCabm { get; set; }
        public string Wheelbasem { get; set; }
        public string TurningRadiusm { get; set; }
        public string Weightkg { get; set; }

        public Brand Brand { get; set; }
        public EntryType EntryType { get; set; }
        public ICollection<Combine> Combine { get; set; }
        public ICollection<CombineImage> CombineImage { get; set; }
    }
}
