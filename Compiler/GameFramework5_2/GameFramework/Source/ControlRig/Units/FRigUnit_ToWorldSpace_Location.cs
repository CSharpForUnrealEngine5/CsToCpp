namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a position / location from rig (global) space to world space</summary>
[CppInclude("Units/Hierarchy/RigUnit_WorldSpace.h")]
public partial struct FRigUnit_ToWorldSpace_Location {
	public FVector Value;
	public FVector World;
}
