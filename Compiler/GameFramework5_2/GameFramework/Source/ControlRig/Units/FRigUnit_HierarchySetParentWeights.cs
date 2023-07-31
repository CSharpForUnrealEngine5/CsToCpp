#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sets the item&#39;s parents&#39; weights</summary>
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_HierarchySetParentWeights {
	public FRigElementKey Child;
	public TArray<FRigElementWeight> Weights;
}
