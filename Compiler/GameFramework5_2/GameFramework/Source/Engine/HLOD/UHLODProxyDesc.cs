#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HLOD/HLODProxyDesc.h")]
///<summary>Describe a LODActor</summary>
public partial class UHLODProxyDesc : UObject {
// HLODProxyDesc
	public TArray<string> SubActors;
	public UStaticMesh StaticMesh;
	public TArray<FHLODISMComponentDesc> ISMComponentsDesc;
	public float LODDrawDistance;
	public bool bOverrideMaterialMergeSettings;
	public FMaterialProxySettings MaterialSettings;
	public bool bOverrideTransitionScreenSize;
	public float TransitionScreenSize;
	public bool bOverrideScreenSize;
	public int ScreenSize;
	public string Key;
	public int LODLevel;
	public string LODActorTag;
	public FVector Location;
	public FTransform HLODBakingTransform;
	public TArray<TSoftObjectPtr<UHLODProxyDesc>> SubHLODDescs;
}
