namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FCreateMeshObjectParams is a collection of input data intended to be passed to</summary>
[CppInclude("ModelingObjectsCreationAPI.h")]
public partial struct FCreateMeshObjectParams {
	public UPrimitiveComponent SourceComponent;
	public ECreateObjectTypeHint TypeHint;
	public UClass TypeHintClass;
	public int TypeHintExtended;
	public UWorld TargetWorld;
	public FTransform Transform;
	public string BaseName;
	public TArray<UMaterialInterface> Materials;
	public TArray<UMaterialInterface> AssetMaterials;
	public bool bEnableCollision;
	public ECollisionTraceFlag CollisionMode;
	public bool bEnableRaytracingSupport;
	public bool bEnableRecomputeNormals;
	public bool bEnableRecomputeTangents;
	public bool bEnableNanite;
	public float NaniteProxyTrianglePercent_DEPRECATED;
	public FMeshNaniteSettings NaniteSettings;
}
