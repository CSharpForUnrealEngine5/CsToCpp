namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a random float between a min and a max</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_Random.h")]
public partial struct FRigVMFunction_RandomFloat {
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
