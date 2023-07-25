#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
///<summary>Decomposes a Transform Array to its components.</summary>
public partial struct FRigVMFunction_MathTransformArrayToSRT {
// RigVMFunction_MathTransformArrayToSRT
	public TArray<FTransform> Transforms;
	public TArray<FVector> Translations;
	public TArray<FQuat> Rotations;
	public TArray<FVector> Scales;
}
