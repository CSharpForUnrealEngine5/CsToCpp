#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describe a LODActor</summary>
[CppInclude("HLOD/HLODProxyDesc.h")]
public partial class UHLODProxyDesc : UObject {
	///<summary>SubActors</summary>
	public TArray<string> SubActors;
	///<summary>StaticMesh</summary>
	public UStaticMesh StaticMesh;
	///<summary>ISMComponentsDesc</summary>
	public TArray<FHLODISMComponentDesc> ISMComponentsDesc;
	///<summary>LODDrawDistance</summary>
	public float LODDrawDistance;
	///<summary>bOverrideMaterialMergeSettings</summary>
	public bool bOverrideMaterialMergeSettings;
	///<summary>MaterialSettings</summary>
	public FMaterialProxySettings MaterialSettings;
	///<summary>bOverrideTransitionScreenSize</summary>
	public bool bOverrideTransitionScreenSize;
	///<summary>TransitionScreenSize</summary>
	public float TransitionScreenSize;
	///<summary>bOverrideScreenSize</summary>
	public bool bOverrideScreenSize;
	///<summary>ScreenSize</summary>
	public int ScreenSize;
	///<summary>Key</summary>
	public string Key;
	///<summary>LODLevel</summary>
	public int LODLevel;
	///<summary>LODActorTag</summary>
	public string LODActorTag;
	///<summary>Location</summary>
	public FVector Location;
	///<summary>HLODBakingTransform</summary>
	public FTransform HLODBakingTransform;
	///<summary>SubHLODDescs</summary>
	public TArray<TSoftObjectPtr<UHLODProxyDesc>> SubHLODDescs;
}
