namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Camera/ParticleModuleCameraOffset.h")]
public partial class UParticleModuleCameraOffset : UParticleModuleCameraBase {
	public static UClass StaticClass() {return default;}
	///<summary>The camera-relative offset to apply to sprite location</summary>
	public FRawDistributionFloat CameraOffset;
	///<summary>If true, the offset will only be processed at spawn time</summary>
	public bool bSpawnTimeOnly;
	///<summary>How to update the offset for this module.</summary>
	public EParticleCameraOffsetUpdateMethod UpdateMethod;
}
