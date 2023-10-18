namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An alternative way to replicating gameplay cues. This does not use fast TArray serialization and does not serialize gameplaycue parameters. The parameters are created on the receiving side with default information.</summary>
[CppInclude("GameplayCueInterface.h")]
public partial struct FMinimalGameplayCueReplicationProxy {
	public UAbilitySystemComponent Owner;
}
