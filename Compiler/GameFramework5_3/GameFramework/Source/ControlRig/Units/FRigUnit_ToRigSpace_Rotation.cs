namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a rotation from world space to rig (global) space</summary>
[CppInclude("Units/Hierarchy/RigUnit_WorldSpace.h")]
public partial struct FRigUnit_ToRigSpace_Rotation {
	public FQuat Value;
	public FQuat Global;
}
