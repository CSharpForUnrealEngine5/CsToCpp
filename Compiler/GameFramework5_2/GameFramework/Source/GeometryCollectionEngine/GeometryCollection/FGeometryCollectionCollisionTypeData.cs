#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionObject.h")]
public partial struct FGeometryCollectionCollisionTypeData {
// GeometryCollectionCollisionTypeData
	public ECollisionTypeEnum CollisionType;
	public EImplicitTypeEnum ImplicitType;
	public FGeometryCollectionLevelSetData LevelSet;
	public FGeometryCollectionCollisionParticleData CollisionParticles;
	public float CollisionObjectReductionPercentage;
	public float CollisionMarginFraction;
}
