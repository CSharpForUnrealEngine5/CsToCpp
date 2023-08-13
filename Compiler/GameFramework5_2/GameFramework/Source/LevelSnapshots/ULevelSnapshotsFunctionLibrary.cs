namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSnapshotsFunctionLibrary.h")]
public partial class ULevelSnapshotsFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>TakeLevelSnapshot</summary>
	public static ULevelSnapshot TakeLevelSnapshot(UObject WorldContextObject,string NewSnapshotName/*="NewLevelSnapshot"*/,string Description/*=""*/) { return default; }
	///<summary>Applies the snapshot to the world. If no filter is specified, the entire snapshot is applied.</summary>
	public static void ApplySnapshotToWorld(UObject WorldContextObject,ULevelSnapshot Snapshot,ULevelSnapshotFilter OptionalFilter) {}
}
