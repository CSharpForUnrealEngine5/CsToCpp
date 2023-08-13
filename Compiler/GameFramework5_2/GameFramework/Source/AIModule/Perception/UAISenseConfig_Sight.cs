namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISenseConfig_Sight.h")]
public partial class UAISenseConfig_Sight : UAISenseConfig {
	public static UClass StaticClass() {return default;}
	///<summary>Implementation</summary>
	public UClass Implementation;
	///<summary>Maximum sight distance to notice a target.</summary>
	public float SightRadius;
	///<summary>Maximum sight distance to see target that has been already seen.</summary>
	public float LoseSightRadius;
	///<summary>How far to the side AI can see, in degrees. Use SetPeripheralVisionAngle to change the value at runtime.</summary>
	public float PeripheralVisionAngleDegrees;
	///<summary>DetectionByAffiliation</summary>
	public FAISenseAffiliationFilter DetectionByAffiliation;
	///<summary>If not an InvalidRange (which is the default), we will always be able to see the target that has already been seen if they are within this range of their last seen location.</summary>
	public float AutoSuccessRangeFromLastSeenLocation;
	///<summary>Point of view move back distance for cone calculation. In conjunction with near clipping distance, this will act as a close by awareness and peripheral vision.</summary>
	public float PointOfViewBackwardOffset;
	///<summary>Near clipping distance, to be used with point of view backward offset. Will act as a close by awareness and peripheral vision</summary>
	public float NearClippingRadius;
}
