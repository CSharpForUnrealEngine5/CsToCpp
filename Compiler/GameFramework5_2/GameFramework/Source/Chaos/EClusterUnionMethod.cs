namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosSolverConfiguration.h")]
public enum EClusterUnionMethod {
	PointImplicit=0,
	DelaunayTriangulation=1,
	MinimalSpanningSubsetDelaunayTriangulation=2,
	PointImplicitAugmentedWithMinimalDelaunay=3,
	BoundsOverlapFilteredDelaunayTriangulation=4,
	None=5,
}
