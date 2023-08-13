namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>LODActor is an instance of an autogenerated StaticMesh Actors by Hierarchical LOD System</summary>
[CppInclude("Engine/LODActor.h")]
public partial class ALODActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>disable display of this component</summary>
	public UStaticMeshComponent StaticMeshComponent;
	///<summary>Imposters to be rendered as instanced static meshes</summary>
	public TMap<FHLODInstancingKey,UInstancedStaticMeshComponent> InstancedStaticMeshComponents;
	///<summary>The mesh proxy used to display this LOD</summary>
	public UHLODProxy Proxy;
	///<summary>The key used to validate this actor against the proxy</summary>
	public string Key;
	///<summary>what distance do you want this to show up instead of SubActors</summary>
	public float LODDrawDistance;
	///<summary>The hierarchy level of this actor; the first tier of HLOD is level 1, the second tier is level 2 and so on.</summary>
	public int LODLevel;
	///<summary>SubActors</summary>
	public TArray<AActor> SubActors;
	///<summary>CachedNumHLODLevels</summary>
	public byte CachedNumHLODLevels;
	///<summary>Cached number of triangles contained in the SubActors</summary>
	public uint NumTrianglesInSubActors;
	///<summary>Cached number of triangles contained in the SubActors</summary>
	public uint NumTrianglesInMergedMesh;
	///<summary>Flag whether or not to use the override MaterialSettings when creating the proxy mesh</summary>
	public bool bOverrideMaterialMergeSettings;
	///<summary>Override Material Settings, used when creating the proxy mesh</summary>
	public FMaterialProxySettings MaterialSettings;
	///<summary>Flag whether or not to use the override TransitionScreenSize for this proxy mesh</summary>
	public bool bOverrideTransitionScreenSize;
	///<summary>Override transition screen size value, determines the screen size at which the proxy is visible</summary>
	public float TransitionScreenSize;
	///<summary>Flag whether or not to use the override ScreenSize when creating the proxy mesh</summary>
	public bool bOverrideScreenSize;
	///<summary>Override screen size value used in mesh reduction, when creating the proxy mesh</summary>
	public int ScreenSize;
	///<summary>OnSubActorEndPlay</summary>
	public void OnSubActorEndPlay(AActor Actor,EEndPlayReason Reason) {}
	///<summary>LODActorTag</summary>
	public string LODActorTag;
	///<summary>bBuiltFromHLODDesc</summary>
	public bool bBuiltFromHLODDesc;
	///<summary>The hlod proxy desc used to build this LODActor</summary>
	public UHLODProxyDesc ProxyDesc;
}
