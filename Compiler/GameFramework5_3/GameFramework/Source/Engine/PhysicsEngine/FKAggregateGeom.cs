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
	public TArray<FKSkinnedLevelSetElem> SkinnedLevelSetElems;
}
