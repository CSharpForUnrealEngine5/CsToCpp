namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a transform from world space to rig (global) space</summary>
[CppInclude("Units/Hierarchy/RigUnit_WorldSpace.h")]
public partial struct FRigUnit_ToRigSpace_Transform {
	public FTransform Value;
	public FTransform Global;
}
