namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug draw parameters for an Axis given a transform</summary>
[CppInclude("RigVMFunctions/Debug/RigVMFunction_VisualDebug.h")]
public partial struct FRigVMFunction_VisualDebugTransformNoSpace {
	public FTransform Value;
	public bool bEnabled;
	public float Thickness;
	public float Scale;
}
