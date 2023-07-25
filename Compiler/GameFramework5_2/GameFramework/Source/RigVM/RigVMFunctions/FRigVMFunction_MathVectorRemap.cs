#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
///<summary>Remaps the given value from a source range to a target range for each component</summary>
public partial struct FRigVMFunction_MathVectorRemap {
// RigVMFunction_MathVectorRemap
	public FVector Value;
	public FVector SourceMinimum;
	public FVector SourceMaximum;
	public FVector TargetMinimum;
	public FVector TargetMaximum;
	public bool bClamp;
	public FVector Result;
}
