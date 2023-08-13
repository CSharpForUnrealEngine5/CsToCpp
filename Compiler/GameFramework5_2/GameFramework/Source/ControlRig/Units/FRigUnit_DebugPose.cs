namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws vectors on each bone in the viewport across the entire pose</summary>
[CppInclude("Units/Debug/RigUnit_DebugHierarchy.h")]
public partial struct FRigUnit_DebugPose {
	public FControlRigExecuteContext ExecuteContext;
	public FRigPose Pose;
	public float Scale;
	public FLinearColor Color;
	public float Thickness;
	public FTransform WorldOffset;
	public bool bEnabled;
}
