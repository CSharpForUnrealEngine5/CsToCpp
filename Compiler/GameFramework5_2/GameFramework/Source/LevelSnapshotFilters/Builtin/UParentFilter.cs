#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/BlueprintOnly/ParentFilter.h")]
public partial class UParentFilter : ULevelSnapshotFilter {
// ParentFilter
	public void AddChild(UObject Filter) {}
	public bool RemovedChild(UObject Filter) { return default; }
	public UObject CreateChild(UClass Class) { return default; }
	public TArray<UObject> GetChildren() { return default; }
	public TArray<ULevelSnapshotFilter> Children;
	public TArray<ULevelSnapshotFilter> InstancedChildren;
}
