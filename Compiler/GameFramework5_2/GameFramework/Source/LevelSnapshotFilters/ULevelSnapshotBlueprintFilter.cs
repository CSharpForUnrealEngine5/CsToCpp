#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSnapshotFilters.h")]
///<summary>Base-class for filtering a level snapshot in Blueprints.</summary>
public partial class ULevelSnapshotBlueprintFilter : ULevelSnapshotFilter {
// LevelSnapshotBlueprintFilter
	public  EFilterResult IsActorValid(FIsActorValidParams Params) { return default; }
	public  EFilterResult IsPropertyValid(FIsPropertyValidParams Params) { return default; }
	public  EFilterResult IsDeletedActorValid(FIsDeletedActorValidParams Params) { return default; }
	public  EFilterResult IsAddedActorValid(FIsAddedActorValidParams Params) { return default; }
	public  EFilterResult IsDeletedComponentValid(FIsDeletedComponentValidParams Params) { return default; }
	public  EFilterResult IsAddedComponentValid(FIsAddedComponentValidParams Params) { return default; }
}
