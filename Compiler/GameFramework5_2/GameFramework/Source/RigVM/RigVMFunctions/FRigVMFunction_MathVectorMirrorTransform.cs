#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
///<summary>Mirror a vector about a central transform.</summary>
public partial struct FRigVMFunction_MathVectorMirrorTransform {
// RigVMFunction_MathVectorMirrorTransform
	public FVector Value;
	public EAxis MirrorAxis;
	public EAxis AxisToFlip;
	public FTransform CentralTransform;
	public FVector Result;
}
