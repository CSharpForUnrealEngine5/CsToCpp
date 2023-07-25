#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
///<summary>Clamps the length of a given vector between a minimum and maximum</summary>
public partial struct FRigVMFunction_MathVectorClampLength {
// RigVMFunction_MathVectorClampLength
	public FVector Value;
	public float MinimumLength;
	public float MaximumLength;
	public FVector Result;
}
