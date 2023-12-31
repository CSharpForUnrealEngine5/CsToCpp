namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Composes a Transform (and Euler Transform) from its components.</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformFromSRT {
	public FVector Location;
	public FVector Rotation;
	public EEulerRotationOrder RotationOrder;
	public FVector Scale;
	public FTransform Transform;
	public FEulerTransform EulerTransform;
}
