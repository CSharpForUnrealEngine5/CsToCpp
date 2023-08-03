#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeOcclusionMapToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Number of occlusion rays per sample</summary>
	public int OcclusionRays;
	///<summary>Maximum distance for occlusion rays to test for intersections; a value of 0 means infinity</summary>
	public float MaxDistance;
	///<summary>Maximum spread angle in degrees for occlusion rays; for example, 180 degrees will cover the entire hemisphere whereas 90 degrees will only cover the center of the hemisphere down to 45 degrees from the horizon.</summary>
	public float SpreadAngle;
	///<summary>Angle in degrees from the horizon for occlusion rays for which the contribution is attenuated to reduce faceting artifacts.</summary>
	public float BiasAngle;
}
