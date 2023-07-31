#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows an actor if it belongs to the specified map.</summary>
[CppInclude("Builtin/ActorInMapFilter.h")]
public partial class UActorInMapFilter : UActorSelectorFilter {
	///<summary>Only actors belonging to this Level are considered.</summary>
	public TArray<TSoftObjectPtr<UWorld>> AllowedLevels;
}
