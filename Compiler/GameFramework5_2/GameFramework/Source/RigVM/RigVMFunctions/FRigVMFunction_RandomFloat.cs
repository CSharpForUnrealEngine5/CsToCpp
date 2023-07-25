#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_Random.h")]
///<summary>Generates a random float between a min and a max</summary>
public partial struct FRigVMFunction_RandomFloat {
// RigVMFunction_RandomFloat
	public int Seed;
	public float Minimum;
	public float Maximum;
	public float Duration;
	public float Result;
	public float LastResult;
	public int LastSeed;
	public int BaseSeed;
	public float TimeLeft;
}
