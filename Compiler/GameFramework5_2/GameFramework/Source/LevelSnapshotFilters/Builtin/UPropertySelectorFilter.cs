#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for filters that only implement IsActorValid</summary>
[CppInclude("Builtin/PropertySelector/PropertySelectorFilter.h")]
public partial class UPropertySelectorFilter : ULevelSnapshotBlueprintFilter {
	///<summary>What to return for IsActorValid, IsDeletedActorValid, and IsAddedActorValid</summary>
	public EFilterResult DefaultResult;
}
