namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Clamps the length of a given vector between a minimum and maximum</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorClampLength {
	public FVector Value;
	public float MinimumLength;
	public float MaximumLength;
	public FVector Result;
}
