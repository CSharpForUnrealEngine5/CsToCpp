#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/AggregateGeom.h")]
///<summary>Container for an aggregate of collision shapes</summary>
public partial struct FKAggregateGeom {
// KAggregateGeom
	public TArray<FKSphereElem> SphereElems;
	public TArray<FKBoxElem> BoxElems;
	public TArray<FKSphylElem> SphylElems;
	public TArray<FKConvexElem> ConvexElems;
	public TArray<FKTaperedCapsuleElem> TaperedCapsuleElems;
	public TArray<FKLevelSetElem> LevelSetElems;
}
