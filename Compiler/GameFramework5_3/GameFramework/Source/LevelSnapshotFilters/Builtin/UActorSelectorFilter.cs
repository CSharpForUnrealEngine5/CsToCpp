namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for filters that only implement IsActorValid</summary>
[CppInclude("Builtin/ActorSelector/ActorSelectorFilter.h")]
public partial class UActorSelectorFilter : ULevelSnapshotBlueprintFilter {
	public static UClass StaticClass() {return default;}
	///<summary>What to return for IsPropertyValid, IsDeletedActorValid, and IsAddedActorValid</summary>
	public EFilterResult DefaultResult;
}
