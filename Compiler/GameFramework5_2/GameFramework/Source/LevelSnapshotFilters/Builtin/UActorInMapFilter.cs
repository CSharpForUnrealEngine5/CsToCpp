#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/ActorInMapFilter.h")]
///<summary>Allows an actor if it belongs to the specified map.</summary>
public partial class UActorInMapFilter : UActorSelectorFilter {
// ActorInMapFilter
	public TArray<TSoftObjectPtr<UWorld>> AllowedLevels;
}
