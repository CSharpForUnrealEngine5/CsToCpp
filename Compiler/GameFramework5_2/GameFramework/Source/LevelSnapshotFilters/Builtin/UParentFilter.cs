#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/BlueprintOnly/ParentFilter.h")]
public partial class UParentFilter : ULevelSnapshotFilter {
// ParentFilter
	public  void AddChild(ULevelSnapshotFilter Filter) {}
	public  bool RemovedChild(ULevelSnapshotFilter Filter) { return default; }
	public  ULevelSnapshotFilter CreateChild(UClass Class) { return default; }
	public  TArray<ULevelSnapshotFilter> GetChildren() { return default; }
	public TArray<ULevelSnapshotFilter> Children;
	public TArray<ULevelSnapshotFilter> InstancedChildren;
}
