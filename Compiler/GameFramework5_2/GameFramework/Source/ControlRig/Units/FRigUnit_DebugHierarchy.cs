#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Debug/RigUnit_DebugHierarchy.h")]
///<summary>Draws vectors on each bone in the viewport across the entire hierarchy</summary>
public partial struct FRigUnit_DebugHierarchy {
// RigUnit_DebugHierarchy
	public FControlRigExecuteContext ExecuteContext;
	public float Scale;
	public FLinearColor Color;
	public float Thickness;
	public FTransform WorldOffset;
	public bool bEnabled;
}
