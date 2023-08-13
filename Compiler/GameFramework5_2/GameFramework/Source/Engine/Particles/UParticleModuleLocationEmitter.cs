namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocationEmitter.h")]
public partial class UParticleModuleLocationEmitter : UParticleModuleLocationBase {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the emitter to use that the source location for particle.</summary>
	public string EmitterName;
	///<summary>The method to use when selecting a spawn target particle from the emitter.</summary>
	public ELocationEmitterSelectionMethod SelectionMethod;
	///<summary>If true, the spawned particle should inherit the velocity of the source particle.</summary>
	public bool InheritSourceVelocity;
	///<summary>Amount to scale the source velocity by when inheriting it.</summary>
	public float InheritSourceVelocityScale;
	///<summary>If true, the spawned particle should inherit the rotation of the source particle.</summary>
	public bool bInheritSourceRotation;
	///<summary>Amount to scale the source rotation by when inheriting it.</summary>
	public float InheritSourceRotationScale;
}
