namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mirror a rotation about a central transform.</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionMirrorTransform {
	public FQuat Value;
	public EAxis MirrorAxis;
	public EAxis AxisToFlip;
	public FTransform CentralTransform;
	public FQuat Result;
}
