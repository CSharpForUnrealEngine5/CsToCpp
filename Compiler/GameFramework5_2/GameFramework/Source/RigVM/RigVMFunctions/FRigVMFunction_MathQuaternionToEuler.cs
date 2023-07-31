#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Retrieves the euler angles in degrees</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionToEuler {
	public FQuat Value;
	public EEulerRotationOrder RotationOrder;
	public FVector Result;
}
