#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionObject.h")]
///<summary>UGeometryCollectionObject (UObject)</summary>
public partial class UGeometryCollection : UObject {
// GeometryCollection
	public bool EnableClustering;
	public int ClusterGroupIndex;
	public int MaxClusterLevel;
	public TArray<float> DamageThreshold;
	public bool bUseSizeSpecificDamageThreshold;
	public bool PerClusterOnlyDamageThreshold;
	public FGeometryCollectionDamagePropagationData DamagePropagationData;
	public EClusterConnectionTypeEnum ClusterConnectionType;
	public float ConnectionGraphBoundsFilteringMargin;
	public TArray<FGeometryCollectionSource> GeometrySource;
	public TArray<UMaterialInterface> Materials;
	public TArray<FGeometryCollectionEmbeddedExemplar> EmbeddedGeometryExemplar;
	public bool bUseFullPrecisionUVs;
	public TArray<FGeometryCollectionAutoInstanceMesh> AutoInstanceMeshes;
	public FSoftObjectPath RootProxy;
	public bool bStripOnCook;
	public bool EnableNanite;
	public ECollisionTypeEnum CollisionType_DEPRECATED;
	public EImplicitTypeEnum ImplicitType_DEPRECATED;
	public int MinLevelSetResolution_DEPRECATED;
	public int MaxLevelSetResolution_DEPRECATED;
	public int MinClusterLevelSetResolution_DEPRECATED;
	public int MaxClusterLevelSetResolution_DEPRECATED;
	public float CollisionObjectReductionPercentage_DEPRECATED;
	public bool bMassAsDensity;
	public float Mass;
	public float MinimumMassClamp;
	public bool bImportCollisionFromSource;
	public float CollisionParticlesFraction_DEPRECATED;
	public int MaximumCollisionParticles_DEPRECATED;
	public bool bRemoveOnMaxSleep;
	public FVector2D MaximumSleepTime;
	public FVector2D RemovalDuration;
	public bool bSlowMovingAsSleeping;
	public float SlowMovingVelocityThreshold;
	public TArray<FGeometryCollectionSizeSpecificData> SizeSpecificData;
	public bool EnableRemovePiecesOnFracture_DEPRECATED;
	public TArray<UMaterialInterface> RemoveOnFractureMaterials_DEPRECATED;
	public UAssetImportData AssetImportData;
	public UThumbnailInfo ThumbnailInfo;
	public UDataflow DataflowAsset;
	public string DataflowTerminal;
	public FGuid PersistentGuid;
	public FGuid StateGuid;
	public int BoneSelectedMaterialIndex;
}
