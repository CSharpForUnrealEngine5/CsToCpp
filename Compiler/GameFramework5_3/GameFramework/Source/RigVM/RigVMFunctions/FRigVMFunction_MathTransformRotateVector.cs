namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rotates a given vector (direction) by the transform</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformRotateVector {
	public FTransform Transform;
	public FVector Vector;
	public FVector Result;
}
