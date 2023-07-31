#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/Prioritization/SphereNetObjectPrioritizer.h")]
public partial class USphereNetObjectPrioritizerConfig : UNetObjectPrioritizerConfig {
	///<summary>InnerRadius</summary>
	public float InnerRadius;
	///<summary>OuterRadius</summary>
	public float OuterRadius;
	///<summary>Priority for objects inside the inner sphere</summary>
	public float InnerPriority;
	///<summary>Priority at the border of the outer sphere</summary>
	public float OuterPriority;
	///<summary>Priority outside the sphere</summary>
	public float OutsidePriority;
}
