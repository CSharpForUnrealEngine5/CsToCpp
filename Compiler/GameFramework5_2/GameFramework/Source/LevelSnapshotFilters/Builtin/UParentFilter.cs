#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/BlueprintOnly/ParentFilter.h")]
public partial class UParentFilter : ULevelSnapshotFilter {
	///<summary>Adds a child you already created to this filter</summary>
	public  void AddChild(ULevelSnapshotFilter Filter) {}
	///<summary>Removes a child from this filter</summary>
	public  bool RemovedChild(ULevelSnapshotFilter Filter) { return default; }
	///<summary>Creates a child and adds it to this filter.</summary>
	public  ULevelSnapshotFilter CreateChild(UClass Class) { return default; }
	///<summary>Gets the children in this filter</summary>
	public  TArray<ULevelSnapshotFilter> GetChildren() { return default; }
	///<summary>Children</summary>
	public TArray<ULevelSnapshotFilter> Children;
	///<summary>InstancedChildren</summary>
	public TArray<ULevelSnapshotFilter> InstancedChildren;
}
