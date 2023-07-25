#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
///<summary>Returns the item's parents' weights</summary>
public partial struct FRigUnit_HierarchyGetParentWeightsArray {
// RigUnit_HierarchyGetParentWeightsArray
	public FRigElementKey Child;
	public TArray<FRigElementWeight> Weights;
	public TArray<FRigElementKey> Parents;
}
