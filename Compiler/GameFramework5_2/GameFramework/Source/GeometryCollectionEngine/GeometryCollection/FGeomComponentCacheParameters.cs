#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionComponent.h")]
public partial struct FGeomComponentCacheParameters {
	public EGeometryCollectionCacheType CacheMode;
	public UGeometryCollectionCache TargetCache;
	public float ReverseCacheBeginTime;
	public bool SaveCollisionData;
	public bool DoGenerateCollisionData;
	public int CollisionDataSizeMax;
	public bool DoCollisionDataSpatialHash;
	public float CollisionDataSpatialHashRadius;
	public int MaxCollisionPerCell;
	public bool SaveBreakingData;
	public bool DoGenerateBreakingData;
	public int BreakingDataSizeMax;
	public bool DoBreakingDataSpatialHash;
	public float BreakingDataSpatialHashRadius;
	public int MaxBreakingPerCell;
	public bool SaveTrailingData;
	public bool DoGenerateTrailingData;
	public int TrailingDataSizeMax;
	public float TrailingMinSpeedThreshold;
	public float TrailingMinVolumeThreshold;
}
