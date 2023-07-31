#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Clamps the given value within the range provided by minimum and maximum for each component</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorClamp {
	public FVector Value;
	public FVector Minimum;
	public FVector Maximum;
	public FVector Result;
}
