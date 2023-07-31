#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionObject.h")]
public partial struct FGeometryCollectionSizeSpecificData {
	public float MaxSize;
	public TArray<FGeometryCollectionCollisionTypeData> CollisionShapes;
	public ECollisionTypeEnum CollisionType_DEPRECATED;
	public EImplicitTypeEnum ImplicitType_DEPRECATED;
	public int MinLevelSetResolution_DEPRECATED;
	public int MaxLevelSetResolution_DEPRECATED;
	public int MinClusterLevelSetResolution_DEPRECATED;
	public int MaxClusterLevelSetResolution_DEPRECATED;
	public int CollisionObjectReductionPercentage_DEPRECATED;
	public float CollisionParticlesFraction_DEPRECATED;
	public int MaximumCollisionParticles_DEPRECATED;
	public int DamageThreshold;
}
