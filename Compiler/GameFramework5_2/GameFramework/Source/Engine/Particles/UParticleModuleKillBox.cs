#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Kill/ParticleModuleKillBox.h")]
public partial class UParticleModuleKillBox : UParticleModuleKillBase {
// ParticleModuleKillBox
	public FRawDistributionVector LowerLeftCorner;
	public FRawDistributionVector UpperRightCorner;
	public bool bAbsolute;
	public bool bKillInside;
	public bool bAxisAlignedAndFixedSize;
}
