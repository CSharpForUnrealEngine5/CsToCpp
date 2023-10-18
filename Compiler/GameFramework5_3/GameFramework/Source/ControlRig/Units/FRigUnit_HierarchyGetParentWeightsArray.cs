namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the item&#39;s parents&#39; weights</summary>
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_HierarchyGetParentWeightsArray {
	public FRigElementKey Child;
	public TArray<FRigElementWeight> Weights;
	public TArray<FRigElementKey> Parents;
}
