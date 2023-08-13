namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a transform from rig (global) space to world space</summary>
[CppInclude("Units/Hierarchy/RigUnit_WorldSpace.h")]
public partial struct FRigUnit_ToWorldSpace_Transform {
	public FTransform Value;
	public FTransform World;
}
