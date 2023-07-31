#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Decomposes a Transform Array to its components.</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformArrayToSRT {
	public TArray<FTransform> Transforms;
	public TArray<FVector> Translations;
	public TArray<FQuat> Rotations;
	public TArray<FVector> Scales;
}
