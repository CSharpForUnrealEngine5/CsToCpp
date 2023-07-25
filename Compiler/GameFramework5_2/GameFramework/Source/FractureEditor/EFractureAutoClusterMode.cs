#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolAutoCluster.h")]
///<summary>Note: Only Voronoi-based auto-clustering is currently supported</summary>
public enum EFractureAutoClusterMode {
	BoundingBox=0,
	Proximity=1,
	Distance=2,
	Voronoi=3,
}
