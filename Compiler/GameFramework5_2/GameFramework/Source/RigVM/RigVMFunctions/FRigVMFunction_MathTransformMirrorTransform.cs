#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
///<summary>Mirror a transform about a central transform.</summary>
public partial struct FRigVMFunction_MathTransformMirrorTransform {
// RigVMFunction_MathTransformMirrorTransform
	public FTransform Value;
	public EAxis MirrorAxis;
	public EAxis AxisToFlip;
	public FTransform CentralTransform;
	public FTransform Result;
}
