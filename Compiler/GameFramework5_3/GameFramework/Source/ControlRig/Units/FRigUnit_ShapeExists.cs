namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Checks whether or not a shape is available in the rig&#39;s shape libraries</summary>
[CppInclude("Units/Core/RigUnit_UserData.h")]
public partial struct FRigUnit_ShapeExists {
	public FName ShapeName;
	public bool Result;
}
