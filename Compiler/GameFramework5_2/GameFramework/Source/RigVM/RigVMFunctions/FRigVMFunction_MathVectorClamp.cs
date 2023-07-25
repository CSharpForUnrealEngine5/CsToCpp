#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
///<summary>Clamps the given value within the range provided by minimum and maximum for each component</summary>
public partial struct FRigVMFunction_MathVectorClamp {
// RigVMFunction_MathVectorClamp
	public FVector Value;
	public FVector Minimum;
	public FVector Maximum;
	public FVector Result;
}
