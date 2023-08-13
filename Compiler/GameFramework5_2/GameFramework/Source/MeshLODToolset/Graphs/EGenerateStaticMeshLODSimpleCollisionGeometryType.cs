namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graphs/GenerateStaticMeshLODProcess.h")]
public enum EGenerateStaticMeshLODSimpleCollisionGeometryType {
	AlignedBoxes=0,
	OrientedBoxes=1,
	MinimalSpheres=2,
	Capsules=3,
	ConvexHulls=4,
	SweptHulls=5,
	MinVolume=6,
	None=7,
}
