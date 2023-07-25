#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CollisionFunctions.h")]
public enum EGeometryScriptCollisionGenerationMethod {
	AlignedBoxes=0,
	OrientedBoxes=1,
	MinimalSpheres=2,
	Capsules=3,
	ConvexHulls=4,
	SweptHulls=5,
	MinVolumeShapes=6,
}
