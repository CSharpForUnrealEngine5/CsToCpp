#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remaps the given value from a source range to a target range for each component</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorRemap {
	public FVector Value;
	public FVector SourceMinimum;
	public FVector SourceMaximum;
	public FVector TargetMinimum;
	public FVector TargetMaximum;
	public bool bClamp;
	public FVector Result;
}
