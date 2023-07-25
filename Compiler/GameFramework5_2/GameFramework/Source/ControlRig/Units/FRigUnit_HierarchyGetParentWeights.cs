#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
///<summary>Returns the item's parents' weights</summary>
public partial struct FRigUnit_HierarchyGetParentWeights {
// RigUnit_HierarchyGetParentWeights
	public FRigElementKey Child;
	public TArray<FRigElementWeight> Weights;
	public FRigElementKeyCollection Parents;
}
