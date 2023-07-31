#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for filters that only implement IsActorValid</summary>
[CppInclude("Builtin/ActorSelector/ActorSelectorFilter.h")]
public partial class UActorSelectorFilter : ULevelSnapshotBlueprintFilter {
	///<summary>What to return for IsPropertyValid, IsDeletedActorValid, and IsAddedActorValid</summary>
	public EFilterResult DefaultResult;
}
