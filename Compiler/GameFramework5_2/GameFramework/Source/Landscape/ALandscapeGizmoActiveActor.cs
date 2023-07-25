#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeGizmoActiveActor.h")]
public partial class ALandscapeGizmoActiveActor : ALandscapeGizmoActor {
// LandscapeGizmoActiveActor
	public byte DataType;
	public UTexture2D GizmoTexture;
	public FVector2D TextureScale;
	public TArray<FVector> SampledHeight;
	public TArray<FVector> SampledNormal;
	public int SampleSizeX;
	public int SampleSizeY;
	public float CachedWidth;
	public float CachedHeight;
	public float CachedScaleXY;
	public FVector FrustumVerts;
	public UMaterial GizmoMaterial;
	public UMaterialInstance GizmoDataMaterial;
	public UMaterial GizmoMeshMaterial;
	public TArray<ULandscapeLayerInfoObject> LayerInfos;
	public ELandscapeGizmoSnapType SnapType;
	public bool bFollowTerrainHeight;
	public FRotator UnsnappedRotation;
}
