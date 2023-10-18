namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the results of a child filter optionally negated.</summary>
[CppInclude("Builtin/BlueprintOnly/NegationFilter.h")]
public partial class UNegationFilter : ULevelSnapshotFilter {
	public static UClass StaticClass() {return default;}
	///<summary>Creates an instanced child.</summary>
	public ULevelSnapshotFilter CreateChild(UClass ChildClass) { return default; }
	///<summary>Creates an instanced child.</summary>
	public void SetExternalChild(ULevelSnapshotFilter NewChild) {}
	///<summary>GetChild</summary>
	public ULevelSnapshotFilter GetChild() { return default; }
	///<summary>bShouldNegate</summary>
	public bool bShouldNegate;
	///<summary>Child</summary>
	public ULevelSnapshotFilter Child;
	///<summary>InstancedChild</summary>
	public ULevelSnapshotFilter InstancedChild;
}
