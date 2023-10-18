namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeGizmoActiveActor.h")]
public partial class ALandscapeGizmoActiveActor : ALandscapeGizmoActor {
	public static UClass StaticClass() {return default;}
	///<summary>DataType</summary>
	public ELandscapeGizmoType DataType;
	///<summary>GizmoTexture</summary>
	public UTexture2D GizmoTexture;
	///<summary>TextureScale</summary>
	public FVector2D TextureScale;
	///<summary>SampledHeight</summary>
	public TArray<FVector> SampledHeight;
	///<summary>SampledNormal</summary>
	public TArray<FVector> SampledNormal;
	///<summary>SampleSizeX</summary>
	public int SampleSizeX;
	///<summary>SampleSizeY</summary>
	public int SampleSizeY;
	///<summary>CachedWidth</summary>
	public float CachedWidth;
	///<summary>CachedHeight</summary>
	public float CachedHeight;
	///<summary>CachedScaleXY</summary>
	public float CachedScaleXY;
	///<summary>FrustumVerts</summary>
	public FVector FrustumVerts;
	///<summary>GizmoMaterial</summary>
	public UMaterial GizmoMaterial;
	///<summary>GizmoDataMaterial</summary>
	public UMaterialInstance GizmoDataMaterial;
	///<summary>GizmoMeshMaterial</summary>
	public UMaterial GizmoMeshMaterial;
	///<summary>LayerInfos</summary>
	public TArray<ULandscapeLayerInfoObject> LayerInfos;
	///<summary>SnapType</summary>
	public ELandscapeGizmoSnapType SnapType;
	///<summary>bFollowTerrainHeight</summary>
	public bool bFollowTerrainHeight;
	///<summary>UnsnappedRotation</summary>
	public FRotator UnsnappedRotation;
}
