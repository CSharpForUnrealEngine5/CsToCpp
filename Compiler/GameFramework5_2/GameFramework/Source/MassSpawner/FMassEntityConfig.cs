#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a Mass agent to spawn. The struct can be embedded to allow last minute changes to the agent (i.e. for debugging).</summary>
[CppInclude("MassEntityConfigAsset.h")]
public partial struct FMassEntityConfig {
	public UMassEntityConfigAsset Parent;
	public TArray<UMassEntityTraitBase> Traits;
}
