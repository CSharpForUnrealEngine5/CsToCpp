namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws vectors on each bone in the viewport across the entire hierarchy</summary>
[CppInclude("Units/Debug/RigUnit_DebugHierarchy.h")]
public partial struct FRigUnit_DebugHierarchy {
	public FControlRigExecuteContext ExecuteContext;
	public float Scale;
	public FLinearColor Color;
	public float Thickness;
	public FTransform WorldOffset;
	public bool bEnabled;
}
