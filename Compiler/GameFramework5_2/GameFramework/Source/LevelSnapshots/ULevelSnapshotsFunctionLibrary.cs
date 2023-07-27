#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSnapshotsFunctionLibrary.h")]
public partial class ULevelSnapshotsFunctionLibrary : UBlueprintFunctionLibrary {
// LevelSnapshotsFunctionLibrary
	public static ULevelSnapshot TakeLevelSnapshot(UObject WorldContextObject,string NewSnapshotName/*="NewLevelSnapshot"*/,string Description/*=""*/) { return default; }
	public static void ApplySnapshotToWorld(UObject WorldContextObject,ULevelSnapshot Snapshot,ULevelSnapshotFilter OptionalFilter) {}
}
