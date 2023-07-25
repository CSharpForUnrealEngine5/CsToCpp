#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StaticMeshComponent.h")]
///<summary>StaticMeshComponent is used to create an instance of a UStaticMesh.</summary>
public partial class UStaticMeshComponent : UMeshComponent {
// StaticMeshComponent
	public int ForcedLodModel;
	public int PreviousLODLevel_DEPRECATED;
	public int MinLOD;
	public int SubDivisionStepSize;
	public UStaticMesh StaticMesh;
	public void OnRep_StaticMesh(UObject OldStaticMesh) {}
	public FColor WireframeColorOverride;
	public bool bDisallowNanite;
	public bool bForceDisableNanite;
	public bool bEvaluateWorldPositionOffset;
	public bool bEvaluateWorldPositionOffsetInRayTracing;
	public int WorldPositionOffsetDisableDistance;
	public int SelectedEditorSection;
	public int SelectedEditorMaterial;
	public int SectionIndexPreview;
	public int MaterialIndexPreview;
	public int StaticMeshImportVersion;
	public bool bOverrideWireframeColor;
	public bool bOverrideMinLOD;
	public bool bOverrideNavigationExport;
	public bool bForceNavigationObstacle;
	public bool bDisallowMeshPaintPerInstance;
	public bool bIgnoreInstanceForTextureStreaming;
	public bool bOverrideLightMapRes;
	public bool bCastDistanceFieldIndirectShadow;
	public bool bOverrideDistanceFieldSelfShadowBias;
	public bool bUseSubDivisions;
	public bool bUseDefaultCollision;
	public bool bCustomOverrideVertexColorPerLOD;
	public bool bDisplayVertexColors;
	public bool bDisplayPhysicalMaterialMasks;
	public bool bDisplayNaniteFallbackMesh;
	public bool bSortTriangles;
	public bool bReverseCulling;
	public int OverriddenLightMapRes;
	public float DistanceFieldIndirectShadowMinVisibility;
	public float DistanceFieldSelfShadowBias;
	public float StreamingDistanceMultiplier;
	public TArray<FGuid> IrrelevantLights_DEPRECATED;
	public TArray<FStaticMeshComponentLODInfo> LODData;
	public TArray<FStreamingTextureBuildInfo> StreamingTextureData;
	public string StaticMeshDerivedDataKey;
	public TArray<uint> MaterialStreamingRelativeBoxes;
	public FLightmassPrimitiveSettings LightmassSettings;
	public bool SetStaticMesh(UObject NewMesh) { return default; }
	public void SetForcedLodModel(int NewForcedLodModel) {}
	public void SetDistanceFieldSelfShadowBias(float NewValue) {}
	public void SetEvaluateWorldPositionOffsetInRayTracing(bool NewValue) {}
	public void SetEvaluateWorldPositionOffset(bool NewValue) {}
	public bool GetInitialEvaluateWorldPositionOffset() { return default; }
	public void GetLocalBounds(FVector Min,FVector Max) {}
	public void SetReverseCulling(bool ReverseCulling) {}
	public void SetForceDisableNanite(bool bInForceDisableNanite) {}
}
