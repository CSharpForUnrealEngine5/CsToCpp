namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the MassCrowd plugin.</summary>
[CppInclude("MassCrowdSettings.h")]
public partial class UMassCrowdSettings : UMassModuleSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Base thickness used to render lane data specific to crowd.</summary>
	public float LaneBaseLineThickness;
	///<summary>Z offset used to render lane data specific to crowd over the actual zone graph.</summary>
	public float LaneRenderZOffset;
	///<summary>Scale factor applied on the base thickness to render intersection lanes data.</summary>
	public float IntersectionLaneScaleFactor;
	///<summary>Scale factor applied on the base or intersection thickness to render density outline.</summary>
	public float LaneDensityScaleFactor;
	///<summary>Color used to render crowd lane that are opened for navigation.</summary>
	public FColor OpenedLaneColor;
	///<summary>Color used to render crowd lane that are closed to navigation.</summary>
	public FColor ClosedLaneColor;
	///<summary>Tag required on a lane to build crowd related runtime data for it and render it.</summary>
	public FZoneGraphTag CrowdTag;
	///<summary>Tag required on a lane to build intersection crossing runtime data for it.</summary>
	public FZoneGraphTag CrossingTag;
	///<summary>Distance reserved for each entity while waiting on an intersection lane.</summary>
	public uint SlotSize;
	///<summary>Offset from the lane entry where the slots are created.</summary>
	public float SlotOffset;
	///<summary>Text will be added on lanes with entity tracking or waiting area to indicate the current occupation</summary>
	public bool bDisplayTrackingData;
	///<summary>Lanes will be displayed to indicates the current state. See MassCrowd settings for parameters.</summary>
	public bool bDisplayStates;
	///<summary>Lanes will be displayed to represent their assigned densities. See MassCrowd settings for parameters.</summary>
	public bool bDisplayDensities;
	///<summary>An obstacle is considered being stopped when it&#39;s speed is less than the tolerance.</summary>
	public float ObstacleStoppingSpeedTolerance;
	///<summary>An obstacle is considered moving when it has moved this much after being stationary.</summary>
	public float ObstacleMovingDistanceTolerance;
	///<summary>The time an obstacle needs to be not moving before it is reported as stopped.</summary>
	public float ObstacleTimeToStop;
	///<summary>The radius an obstacle has effects on navigation.</summary>
	public float ObstacleEffectRadius;
	///<summary>Distance ahead of the current lane location for the next movement target location.</summary>
	public float MoveDistance;
	///<summary>Random deviation of the of the MoveDistance</summary>
	public float MoveDistanceRandomDeviation;
	///<summary>List of all lane density descriptors.</summary>
	public TArray<FMassCrowdLaneDensityDesc> LaneDensities;
}
