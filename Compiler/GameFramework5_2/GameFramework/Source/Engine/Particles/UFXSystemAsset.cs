#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleSystem.h")]
public partial class UFXSystemAsset : UObject {
	///<summary>Max number of components of this system to keep resident in the world component pool.</summary>
	public uint MaxPoolSize;
	///<summary>How many instances we should use to initially prime the pool.</summary>
	public uint PoolPrimeSize;
}
