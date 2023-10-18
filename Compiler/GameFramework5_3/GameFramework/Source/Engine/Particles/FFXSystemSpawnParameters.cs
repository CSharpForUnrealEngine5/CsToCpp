namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters controlling the spawning behavior of FX systems via the SpawnSystemAtLocation and SpawnSystemAttached.</summary>
[CppInclude("Particles/ParticleSystemComponent.h")]
public partial struct FFXSystemSpawnParameters {
	public UObject WorldContextObject;
	public UFXSystemAsset SystemTemplate;
	public FVector Location;
	public FRotator Rotation;
	public FVector Scale;
	public USceneComponent AttachToComponent;
	public FName AttachPointName;
	public EAttachLocation LocationType;
	public bool bAutoDestroy;
	public bool bAutoActivate;
	public EPSCPoolMethod PoolingMethod;
	public bool bPreCullCheck;
	public bool bIsPlayerEffect;
}
