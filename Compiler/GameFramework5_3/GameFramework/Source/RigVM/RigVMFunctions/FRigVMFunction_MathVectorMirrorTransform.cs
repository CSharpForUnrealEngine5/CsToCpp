namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mirror a vector about a central transform.</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorMirrorTransform {
	public FVector Value;
	public EAxis MirrorAxis;
	public EAxis AxisToFlip;
	public FTransform CentralTransform;
	public FVector Result;
}
