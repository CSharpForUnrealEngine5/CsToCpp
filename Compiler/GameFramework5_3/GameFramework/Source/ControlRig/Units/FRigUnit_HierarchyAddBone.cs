namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds a new bone to the hierarchy</summary>
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_HierarchyAddBone {
	public FTransform Transform;
	public ERigVMTransformSpace Space;
}
