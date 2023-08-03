#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Spawn/ParticleModuleSpawnPerUnit.h")]
public partial class UParticleModuleSpawnPerUnit : UParticleModuleSpawnBase {
	public static UClass StaticClass() {return default;}
	///<summary>The scalar to apply to the distance traveled.</summary>
	public float UnitScalar;
	///<summary>The tolerance for moving vs. not moving w.r.t. the bIgnoreSpawnRateWhenMoving flag.</summary>
	public float MovementTolerance;
	///<summary>The amount to spawn per meter distribution.</summary>
	public FRawDistributionFloat SpawnPerUnit;
	///<summary>The maximum valid movement for a single frame.</summary>
	public float MaxFrameDistance;
	///<summary>If true, process the default spawn rate when not moving...</summary>
	public bool bIgnoreSpawnRateWhenMoving;
	///<summary>If true, ignore the X-component of the movement</summary>
	public bool bIgnoreMovementAlongX;
	///<summary>If true, ignore the Y-component of the movement</summary>
	public bool bIgnoreMovementAlongY;
	///<summary>If true, ignore the Z-component of the movement</summary>
	public bool bIgnoreMovementAlongZ;
}
