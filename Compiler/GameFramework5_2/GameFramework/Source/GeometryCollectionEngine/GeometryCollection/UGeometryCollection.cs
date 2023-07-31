#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGeometryCollectionObject (UObject)</summary>
[CppInclude("GeometryCollection/GeometryCollectionObject.h")]
public partial class UGeometryCollection : UObject {
	///<summary>EnableClustering</summary>
	public bool EnableClustering;
	///<summary>Maximum level for cluster breaks.</summary>
	public int ClusterGroupIndex;
	///<summary>Maximum level for cluster breaks.</summary>
	public int MaxClusterLevel;
	///<summary>Damage threshold for clusters at different levels.</summary>
	public TArray<float> DamageThreshold;
	///<summary>whether to use size specific damage threshold instead of level based ones ( see Size Specific Data array ).</summary>
	public bool bUseSizeSpecificDamageThreshold;
	///<summary>compatibility check, when true, only cluster compute damage from parameters and propagate to direct children</summary>
	public bool PerClusterOnlyDamageThreshold;
	///<summary>Data about how damage propagation shoudl behave.</summary>
	public FGeometryCollectionDamagePropagationData DamagePropagationData;
	///<summary>ClusterConnectionType</summary>
	public EClusterConnectionTypeEnum ClusterConnectionType;
	///<summary>ConnectionGraphBoundsFilteringMargin</summary>
	public float ConnectionGraphBoundsFilteringMargin;
	///<summary>GeometrySource</summary>
	public TArray<FGeometryCollectionSource> GeometrySource;
	///<summary>Materials</summary>
	public TArray<UMaterialInterface> Materials;
	///<summary>References for embedded geometry generation</summary>
	public TArray<FGeometryCollectionEmbeddedExemplar> EmbeddedGeometryExemplar;
	///<summary>Whether to use full precision UVs when rendering this geometry. (Does not apply to Nanite rendering)</summary>
	public bool bUseFullPrecisionUVs;
	///<summary>list of unique static mesh / materials pairs for auto instancing</summary>
	public TArray<FGeometryCollectionAutoInstanceMesh> AutoInstanceMeshes;
	///<summary>static mesh to use as a proxy for rendering until the geometry collection is broken</summary>
	public FSoftObjectPath RootProxy;
	///<summary>Strip unnecessary data from the Geometry Collection to keep the memory footprint as small as possible.</summary>
	public bool bStripOnCook;
	///<summary>Enable support for Nanite.</summary>
	public bool EnableNanite;
	///<summary>*  CollisionType defines how to initialize the rigid collision structures.</summary>
	public ECollisionTypeEnum CollisionType_DEPRECATED;
	///<summary>*  CollisionType defines how to initialize the rigid collision structures.</summary>
	public EImplicitTypeEnum ImplicitType_DEPRECATED;
	///<summary>*  Resolution on the smallest axes for the level set. (def: 5)</summary>
	public int MinLevelSetResolution_DEPRECATED;
	///<summary>*  Resolution on the smallest axes for the level set. (def: 10)</summary>
	public int MaxLevelSetResolution_DEPRECATED;
	///<summary>*  Resolution on the smallest axes for the level set. (def: 5)</summary>
	public int MinClusterLevelSetResolution_DEPRECATED;
	///<summary>*  Resolution on the smallest axes for the level set. (def: 10)</summary>
	public int MaxClusterLevelSetResolution_DEPRECATED;
	///<summary>*  Resolution on the smallest axes for the level set. (def: 10)</summary>
	public float CollisionObjectReductionPercentage_DEPRECATED;
	///<summary>Mass As Density, units are in kg/m^3</summary>
	public bool bMassAsDensity;
	///<summary>Total Mass of Collection. If density, units are in kg/m^3</summary>
	public float Mass;
	///<summary>Smallest allowable mass (def:0.1)</summary>
	public float MinimumMassClamp;
	///<summary>whether to import collision from the source asset</summary>
	public bool bImportCollisionFromSource;
	///<summary>Number of particles on the triangulated surface to use for collisions.</summary>
	public float CollisionParticlesFraction_DEPRECATED;
	///<summary>Max number of particles.</summary>
	public int MaximumCollisionParticles_DEPRECATED;
	///<summary>Remove particle from simulation and dissolve rendered geometry once sleep threshold has been exceeded.</summary>
	public bool bRemoveOnMaxSleep;
	///<summary>How long may the particle sleep before initiating removal (in seconds).</summary>
	public FVector2D MaximumSleepTime;
	///<summary>How long does the removal process take (in seconds).</summary>
	public FVector2D RemovalDuration;
	///<summary>when on non-sleeping, slow moving pieces will be considered as sleeping, this helps removal of jittery but not really moving objects.</summary>
	public bool bSlowMovingAsSleeping;
	///<summary>When slow moving detection is on, this defines the linear velocity thresholds in cm/s to consider the object as sleeping .</summary>
	public float SlowMovingVelocityThreshold;
	///<summary>* Size Specfic Data reflects the default geometry to bind to rigid bodies smaller</summary>
	public TArray<FGeometryCollectionSizeSpecificData> SizeSpecificData;
	///<summary>Enable remove pieces on fracture</summary>
	public bool EnableRemovePiecesOnFracture_DEPRECATED;
	///<summary>Materials relating to remove on fracture</summary>
	public TArray<UMaterialInterface> RemoveOnFractureMaterials_DEPRECATED;
	///<summary>Importing data and options used for this geometry collection</summary>
	public UAssetImportData AssetImportData;
	///<summary>Information for thumbnail rendering</summary>
	public UThumbnailInfo ThumbnailInfo;
	///<summary>Dataflow</summary>
	public UDataflow DataflowAsset;
	///<summary>DataflowTerminal</summary>
	public string DataflowTerminal;
	///<summary>Guid created on construction of this collection. It should be used to uniquely identify this collection</summary>
	public FGuid PersistentGuid;
	///<summary>Guid that can be invalidated on demand - essentially a &#39;version&#39; that should be changed when a structural change is made to</summary>
	public FGuid StateGuid;
	///<summary>#todo(dmp): rename to be consistent BoneSelectedMaterialID?</summary>
	public int BoneSelectedMaterialIndex;
}
