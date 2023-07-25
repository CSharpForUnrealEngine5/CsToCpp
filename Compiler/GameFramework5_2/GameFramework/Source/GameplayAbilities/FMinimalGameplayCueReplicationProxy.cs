#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueInterface.h")]
///<summary>An alternative way to replicating gameplay cues. This does not use fast TArray serialization and does not serialize gameplaycue parameters. The parameters are created on the receiving side with default information.</summary>
public partial struct FMinimalGameplayCueReplicationProxy {
// MinimalGameplayCueReplicationProxy
	public UAbilitySystemComponent Owner;
}
