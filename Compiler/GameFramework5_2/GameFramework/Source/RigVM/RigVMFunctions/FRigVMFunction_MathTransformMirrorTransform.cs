namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mirror a transform about a central transform.</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformMirrorTransform {
	public FTransform Value;
	public EAxis MirrorAxis;
	public EAxis AxisToFlip;
	public FTransform CentralTransform;
	public FTransform Result;
}
