namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base-class for filtering a level snapshot in Blueprints.</summary>
[CppInclude("LevelSnapshotFilters.h")]
public partial class ULevelSnapshotBlueprintFilter : ULevelSnapshotFilter {
	public static UClass StaticClass() {return default;}
	///<summary>@return Whether the actor should be considered for the level snapshot.</summary>
	public EFilterResult IsActorValid(FIsActorValidParams Params) { return default; }
	///<summary>@return Whether this property should be considered for rolling back to the version in the snapshot.</summary>
	public EFilterResult IsPropertyValid(FIsPropertyValidParams Params) { return default; }
	///<summary>This is called when an actor was removed from the world since the snapshot had been taken.</summary>
	public EFilterResult IsDeletedActorValid(FIsDeletedActorValidParams Params) { return default; }
	///<summary>This is called when an actor was added to the world since the snapshot had been taken.</summary>
	public EFilterResult IsAddedActorValid(FIsAddedActorValidParams Params) { return default; }
	///<summary>This is called when a component was removed from an actor since the snapshot had been taken.</summary>
	public EFilterResult IsDeletedComponentValid(FIsDeletedComponentValidParams Params) { return default; }
	///<summary>This is called when a component was added to the world since the snapshot had been taken.</summary>
	public EFilterResult IsAddedComponentValid(FIsAddedComponentValidParams Params) { return default; }
}
