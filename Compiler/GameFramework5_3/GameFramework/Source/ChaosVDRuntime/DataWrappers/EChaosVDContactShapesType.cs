namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataWrappers/ChaosVDCollisionDataWrappers.h")]
public enum EChaosVDContactShapesType {
	Unknown=0,
	SphereSphere=1,
	SphereCapsule=2,
	SphereBox=3,
	SphereConvex=4,
	SphereTriMesh=5,
	SphereHeightField=6,
	SpherePlane=7,
	CapsuleCapsule=8,
	CapsuleBox=9,
	CapsuleConvex=10,
	CapsuleTriMesh=11,
	CapsuleHeightField=12,
	BoxBox=13,
	BoxConvex=14,
	BoxTriMesh=15,
	BoxHeightField=16,
	BoxPlane=17,
	ConvexConvex=18,
	ConvexTriMesh=19,
	ConvexHeightField=20,
	GenericConvexConvex=21,
	LevelSetLevelSet=22,
	NumShapesTypes=23,
}
