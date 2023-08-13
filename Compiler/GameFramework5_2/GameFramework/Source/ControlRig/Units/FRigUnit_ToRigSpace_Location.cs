namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a position / location from world space to rig (global) space</summary>
[CppInclude("Units/Hierarchy/RigUnit_WorldSpace.h")]
public partial struct FRigUnit_ToRigSpace_Location {
	public FVector Value;
	public FVector Global;
}
