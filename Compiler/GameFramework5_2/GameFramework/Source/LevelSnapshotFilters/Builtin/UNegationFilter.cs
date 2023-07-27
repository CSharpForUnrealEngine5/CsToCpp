#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/BlueprintOnly/NegationFilter.h")]
///<summary>Returns the results of a child filter optionally negated.</summary>
public partial class UNegationFilter : ULevelSnapshotFilter {
// NegationFilter
	public  ULevelSnapshotFilter CreateChild(UClass ChildClass) { return default; }
	public  void SetExternalChild(ULevelSnapshotFilter NewChild) {}
	public  ULevelSnapshotFilter GetChild() { return default; }
	public bool bShouldNegate;
	public ULevelSnapshotFilter Child;
	public ULevelSnapshotFilter InstancedChild;
}
