#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a random vector between a min and a max</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_Random.h")]
public partial struct FRigVMFunction_RandomVector {
	public int Seed;
	public float Minimum;
	public float Maximum;
	public float Duration;
	public FVector Result;
	public FVector LastResult;
	public int LastSeed;
	public int BaseSeed;
	public float TimeLeft;
}
