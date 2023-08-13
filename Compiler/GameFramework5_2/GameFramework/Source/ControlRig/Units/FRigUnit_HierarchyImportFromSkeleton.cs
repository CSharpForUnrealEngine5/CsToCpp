namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Imports all bones (and curves) from the currently assigned skeleton.</summary>
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_HierarchyImportFromSkeleton {
	public string NameSpace;
	public bool bIncludeCurves;
	public TArray<FRigElementKey> Items;
}
