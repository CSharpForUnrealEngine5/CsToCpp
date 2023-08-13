namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a rotation from rig (global) space to world space</summary>
[CppInclude("Units/Hierarchy/RigUnit_WorldSpace.h")]
public partial struct FRigUnit_ToWorldSpace_Rotation {
	public FQuat Value;
	public FQuat World;
}
