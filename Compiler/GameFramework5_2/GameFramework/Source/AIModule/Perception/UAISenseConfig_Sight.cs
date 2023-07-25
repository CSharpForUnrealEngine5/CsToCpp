#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISenseConfig_Sight.h")]
public partial class UAISenseConfig_Sight : UAISenseConfig {
// AISenseConfig_Sight
	public UClass Implementation;
	public float SightRadius;
	public float LoseSightRadius;
	public float PeripheralVisionAngleDegrees;
	public FAISenseAffiliationFilter DetectionByAffiliation;
	public float AutoSuccessRangeFromLastSeenLocation;
	public float PointOfViewBackwardOffset;
	public float NearClippingRadius;
}
