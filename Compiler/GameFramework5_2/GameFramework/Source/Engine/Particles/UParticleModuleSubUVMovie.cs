#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/SubUV/ParticleModuleSubUVMovie.h")]
public partial class UParticleModuleSubUVMovie : UParticleModuleSubUV {
	///<summary>If true, use the emitter time to look up the frame rate.</summary>
	public bool bUseEmitterTime;
	///<summary>The frame rate the SubUV images should be &#39;flipped&#39; thru at.</summary>
	public FRawDistributionFloat FrameRate;
	///<summary>The starting image index for the SubUV (1 = the first frame).</summary>
	public int StartingFrame;
}
