#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Rotation/ParticleModuleMeshRotation.h")]
public partial class UParticleModuleMeshRotation : UParticleModuleRotationBase {
	public static UClass StaticClass() {return default;}
	///<summary>Initial rotation in ROTATIONS PER SECOND (1 = 360 degrees).</summary>
	public FRawDistributionVector StartRotation;
	///<summary>If true, apply the parents rotation as well.</summary>
	public bool bInheritParent;
}
