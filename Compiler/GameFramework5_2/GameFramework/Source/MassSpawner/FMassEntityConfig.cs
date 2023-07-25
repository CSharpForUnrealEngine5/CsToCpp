#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassEntityConfigAsset.h")]
///<summary>Describes a Mass agent to spawn. The struct can be embedded to allow last minute changes to the agent (i.e. for debugging).</summary>
public partial struct FMassEntityConfig {
// MassEntityConfig
	public UMassEntityConfigAsset Parent;
	public TArray<UMassEntityTraitBase> Traits;
}
