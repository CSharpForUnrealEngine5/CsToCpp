#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for an aggregate of collision shapes</summary>
[CppInclude("PhysicsEngine/AggregateGeom.h")]
public partial struct FKAggregateGeom {
	public TArray<FKSphereElem> SphereElems;
	public TArray<FKBoxElem> BoxElems;
	public TArray<FKSphylElem> SphylElems;
	public TArray<FKConvexElem> ConvexElems;
	public TArray<FKTaperedCapsuleElem> TaperedCapsuleElems;
	public TArray<FKLevelSetElem> LevelSetElems;
}
