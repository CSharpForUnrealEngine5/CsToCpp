namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for filters that only implement IsActorValid</summary>
[CppInclude("Builtin/PropertySelector/PropertySelectorFilter.h")]
public partial class UPropertySelectorFilter : ULevelSnapshotBlueprintFilter {
	public static UClass StaticClass() {return default;}
	///<summary>What to return for IsActorValid, IsDeletedActorValid, and IsAddedActorValid</summary>
	public EFilterResult DefaultResult;
}
