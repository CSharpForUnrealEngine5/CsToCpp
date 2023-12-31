namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug draw parameters for an Axis given a quaternion</summary>
[CppInclude("RigVMFunctions/Debug/RigVMFunction_VisualDebug.h")]
public partial struct FRigVMFunction_VisualDebugQuatNoSpace {
	public FQuat Value;
	public bool bEnabled;
	public float Thickness;
	public float Scale;
}
