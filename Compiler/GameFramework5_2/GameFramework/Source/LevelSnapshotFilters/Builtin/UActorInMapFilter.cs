namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows an actor if it belongs to the specified map.</summary>
[CppInclude("Builtin/ActorInMapFilter.h")]
public partial class UActorInMapFilter : UActorSelectorFilter {
	public static UClass StaticClass() {return default;}
	///<summary>Only actors belonging to this Level are considered.</summary>
	public TArray<TSoftObjectPtr<UWorld>> AllowedLevels;
}
