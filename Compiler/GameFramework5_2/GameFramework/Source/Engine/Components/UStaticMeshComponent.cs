namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>StaticMeshComponent is used to create an instance of a UStaticMesh.</summary>
[CppInclude("Components/StaticMeshComponent.h")]
public partial class UStaticMeshComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>If 0, auto-select LOD level. if &gt;0, force to (ForcedLodModel-1).</summary>
	public int ForcedLodModel;
	///<summary>LOD that was desired for rendering this StaticMeshComponent last frame.</summary>
	public int PreviousLODLevel_DEPRECATED;
	///<summary>Specifies the smallest LOD that will be used for this component.</summary>
	public int MinLOD;
	///<summary>Subdivision step size for static vertex lighting.</summary>
	public int SubDivisionStepSize;
	///<summary>StaticMesh</summary>
	public UStaticMesh StaticMesh;
	///<summary>OnRep_StaticMesh</summary>
	public void OnRep_StaticMesh(UStaticMesh OldStaticMesh) {}
	///<summary>Wireframe color to use if bOverrideWireframeColor is true</summary>
	public FColor WireframeColorOverride;
	///<summary>Forces this component to use fallback mesh for rendering if Nanite is enabled on the mesh.</summary>
	public bool bDisallowNanite;
	///<summary>Forces this component to use fallback mesh for rendering if Nanite is enabled on the mesh (run-time override)</summary>
	public bool bForceDisableNanite;
	///<summary>Whether to evaluate World Position Offset.</summary>
	public bool bEvaluateWorldPositionOffset;
	///<summary>Whether to evaluate World Position Offset for ray tracing.</summary>
	public bool bEvaluateWorldPositionOffsetInRayTracing;
	///<summary>Distance at which to disable World Position Offset for an entire instance (0 = Never disable WPO).</summary>
	public int WorldPositionOffsetDisableDistance;
	///<summary>The section currently selected in the Editor. Used for highlighting</summary>
	public int SelectedEditorSection;
	///<summary>The material currently selected in the Editor. Used for highlighting</summary>
	public int SelectedEditorMaterial;
	///<summary>Index of the section to preview. If set to INDEX_NONE, all section will be rendered. Used for isolating in Static Mesh Tool *</summary>
	public int SectionIndexPreview;
	///<summary>Index of the material to preview. If set to INDEX_NONE, all section will be rendered. Used for isolating in Static Mesh Tool *</summary>
	public int MaterialIndexPreview;
	///<summary>* The import version of the static mesh when it was assign this is update when:</summary>
	public int StaticMeshImportVersion;
	///<summary>If true, WireframeColorOverride will be used. If false, color is determined based on mobility and physics simulation settings</summary>
	public bool bOverrideWireframeColor;
	///<summary>Whether to override the MinLOD setting of the static mesh asset with the MinLOD of this component.</summary>
	public bool bOverrideMinLOD;
	///<summary>If true, bForceNavigationObstacle flag will take priority over navigation data stored in StaticMesh</summary>
	public bool bOverrideNavigationExport;
	///<summary>Allows overriding navigation export behavior per component: full collisions or dynamic obstacle</summary>
	public bool bForceNavigationObstacle;
	///<summary>If true, mesh painting is disallowed on this instance. Set if vertex colors are overridden in a construction script.</summary>
	public bool bDisallowMeshPaintPerInstance;
	///<summary>Ignore this instance of this static mesh when calculating streaming information.</summary>
	public bool bIgnoreInstanceForTextureStreaming;
	///<summary>Whether to override the lightmap resolution defined in the static mesh.</summary>
	public bool bOverrideLightMapRes;
	///<summary>Whether to use the mesh distance field representation (when present) for shadowing indirect lighting (from lightmaps or skylight) on Movable components.</summary>
	public bool bCastDistanceFieldIndirectShadow;
	///<summary>Whether to override the DistanceFieldSelfShadowBias setting of the static mesh asset with the DistanceFieldSelfShadowBias of this component.</summary>
	public bool bOverrideDistanceFieldSelfShadowBias;
	///<summary>Whether to use subdivisions or just the triangle&#39;s vertices.</summary>
	public bool bUseSubDivisions;
	///<summary>Use the collision profile specified in the StaticMesh asset.</summary>
	public bool bUseDefaultCollision;
	///<summary>The component has some custom painting on LODs or not.</summary>
	public bool bCustomOverrideVertexColorPerLOD;
	///<summary>bDisplayVertexColors</summary>
	public bool bDisplayVertexColors;
	///<summary>bDisplayPhysicalMaterialMasks</summary>
	public bool bDisplayPhysicalMaterialMasks;
	///<summary>For Nanite enabled meshes, we&#39;ll only show the proxy mesh if this is true</summary>
	public bool bDisplayNaniteFallbackMesh;
	///<summary>Enable dynamic sort mesh&#39;s triangles to remove ordering issue when rendered with a translucent material</summary>
	public bool bSortTriangles;
	///<summary>Controls whether the static mesh component&#39;s backface culling should be reversed</summary>
	public bool bReverseCulling;
	///<summary>Light map resolution to use on this component, used if bOverrideLightMapRes is true and there is a valid StaticMesh.</summary>
	public int OverriddenLightMapRes;
	///<summary>Controls how dark the dynamic indirect shadow can be.</summary>
	public float DistanceFieldIndirectShadowMinVisibility;
	///<summary>Useful for reducing self shadowing from distance field methods when using world position offset to animate the mesh&#39;s vertices.</summary>
	public float DistanceFieldSelfShadowBias;
	///<summary>Allows adjusting the desired resolution of streaming textures that uses UV 0.  1.0 is the default, whereas a higher value increases the streamed-in resolution.</summary>
	public float StreamingDistanceMultiplier;
	///<summary>IrrelevantLights_DEPRECATED</summary>
	public TArray<FGuid> IrrelevantLights_DEPRECATED;
	///<summary>Static mesh LOD data.  Contains static lighting data along with instanced mesh vertex colors.</summary>
	public TArray<FStaticMeshComponentLODInfo> LODData;
	///<summary>The list of texture, bounds and scales. As computed in the texture streaming build process.</summary>
	public TArray<FStreamingTextureBuildInfo> StreamingTextureData;
	///<summary>Derived data key of the static mesh, used to determine if an update from the source static mesh is required.</summary>
	public string StaticMeshDerivedDataKey;
	///<summary>Material Bounds used for texture streaming.</summary>
	public TArray<uint> MaterialStreamingRelativeBoxes;
	///<summary>The Lightmass settings for this object.</summary>
	public FLightmassPrimitiveSettings LightmassSettings;
	///<summary>Change the StaticMesh used by this instance.</summary>
	public virtual bool SetStaticMesh(UStaticMesh NewMesh) { return default; }
	///<summary>SetForcedLodModel</summary>
	public void SetForcedLodModel(int NewForcedLodModel) {}
	///<summary>Sets the component&#39;s DistanceFieldSelfShadowBias.  bOverrideDistanceFieldSelfShadowBias must be enabled for this to have an effect.</summary>
	public void SetDistanceFieldSelfShadowBias(float NewValue) {}
	///<summary>SetEvaluateWorldPositionOffsetInRayTracing</summary>
	public void SetEvaluateWorldPositionOffsetInRayTracing(bool NewValue) {}
	///<summary>SetEvaluateWorldPositionOffset</summary>
	public void SetEvaluateWorldPositionOffset(bool NewValue) {}
	///<summary>Get the initial value of bEvaluateWorldPositionOffset. This is the value when BeginPlay() was last called.</summary>
	public bool GetInitialEvaluateWorldPositionOffset() { return default; }
	///<summary>Get Local bounds</summary>
	public void GetLocalBounds(FVector Min,FVector Max) {}
	///<summary>Set forced reverse culling</summary>
	public void SetReverseCulling(bool ReverseCulling) {}
	///<summary>Force disabling of Nanite rendering. When true, Will swap to the the fallback mesh instead.</summary>
	public void SetForceDisableNanite(bool bInForceDisableNanite) {}
}
