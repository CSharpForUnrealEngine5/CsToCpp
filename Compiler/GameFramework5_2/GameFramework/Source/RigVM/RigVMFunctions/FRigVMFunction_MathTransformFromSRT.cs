#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
///<summary>Composes a Transform (and Euler Transform) from its components.</summary>
public partial struct FRigVMFunction_MathTransformFromSRT {
// RigVMFunction_MathTransformFromSRT
	public FVector Location;
	public FVector Rotation;
	public EEulerRotationOrder RotationOrder;
	public FVector Scale;
	public FTransform Transform;
	public FEulerTransform EulerTransform;
}
