namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a transform from its components</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformMake {
	public FVector Translation;
	public FQuat Rotation;
	public FVector Scale;
	public FTransform Result;
}
