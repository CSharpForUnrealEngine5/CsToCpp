#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/SetCollisionGeometryTool.h")]
public enum ECollisionGeometryType {
	KeepExisting=0,
	AlignedBoxes=1,
	OrientedBoxes=2,
	MinimalSpheres=3,
	Capsules=4,
	ConvexHulls=5,
	SweptHulls=6,
	LevelSets=7,
	MinVolume=10,
	None=11,
}
