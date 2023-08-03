#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/Prioritization/SphereWithOwnerBoostNetObjectPrioritizer.h")]
public partial class USphereWithOwnerBoostNetObjectPrioritizerConfig : USphereNetObjectPrioritizerConfig {
	public static UClass StaticClass() {return default;}
	///<summary>Priority boost for the owning connection. Added to the priority calculated by the sphere prioritizer.</summary>
	public float OwnerPriorityBoost;
}
