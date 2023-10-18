namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshMerging.h")]
public enum EMeshApproximationSimplificationPolicy {
	FixedTriangleCount=0,
	TrianglesPerArea=1,
	GeometricTolerance=2,
}
