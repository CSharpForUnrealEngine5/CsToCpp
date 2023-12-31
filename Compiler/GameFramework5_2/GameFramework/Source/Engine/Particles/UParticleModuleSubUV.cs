namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/SubUV/ParticleModuleSubUV.h")]
public partial class UParticleModuleSubUV : UParticleModuleSubUVBase {
	public static UClass StaticClass() {return default;}
	///<summary>SubUV animation asset to use.</summary>
	public USubUVAnimation Animation;
	///<summary>The index of the sub-image that should be used for the particle.</summary>
	public FRawDistributionFloat SubImageIndex;
	///<summary>If true, use *real* time when updating the image index.</summary>
	public bool bUseRealTime;
}
