namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug draw parameters for an Axis given a quaternion</summary>
[CppInclude("Units/Debug/RigUnit_VisualDebug.h")]
public partial struct FRigUnit_VisualDebugQuatItemSpace {
	public FQuat Value;
	public bool bEnabled;
	public float Thickness;
	public float Scale;
	public FRigElementKey Space;
}
