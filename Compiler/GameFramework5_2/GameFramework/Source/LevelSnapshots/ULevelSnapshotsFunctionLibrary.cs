#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSnapshotsFunctionLibrary.h")]
public partial class ULevelSnapshotsFunctionLibrary : UBlueprintFunctionLibrary {
// LevelSnapshotsFunctionLibrary
	public UObject TakeLevelSnapshot(UObject WorldContextObject,string NewSnapshotName/*="NewLevelSnapshot"*/,string Description/*=""*/) { return default; }
	public void ApplySnapshotToWorld(UObject WorldContextObject,UObject Snapshot,UObject OptionalFilter) {}
}
