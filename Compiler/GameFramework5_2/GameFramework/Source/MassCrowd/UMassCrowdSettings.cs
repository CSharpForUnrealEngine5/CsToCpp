#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassCrowdSettings.h")]
///<summary>Settings for the MassCrowd plugin.</summary>
public partial class UMassCrowdSettings : UMassModuleSettings {
// MassCrowdSettings
	public float LaneBaseLineThickness;
	public float LaneRenderZOffset;
	public float IntersectionLaneScaleFactor;
	public float LaneDensityScaleFactor;
	public FColor OpenedLaneColor;
	public FColor ClosedLaneColor;
	public FZoneGraphTag CrowdTag;
	public FZoneGraphTag CrossingTag;
	public uint SlotSize;
	public float SlotOffset;
	public bool bDisplayTrackingData;
	public bool bDisplayStates;
	public bool bDisplayDensities;
	public float ObstacleStoppingSpeedTolerance;
	public float ObstacleMovingDistanceTolerance;
	public float ObstacleTimeToStop;
	public float ObstacleEffectRadius;
	public float MoveDistance;
	public float MoveDistanceRandomDeviation;
	public TArray<FMassCrowdLaneDensityDesc> LaneDensities;
}
