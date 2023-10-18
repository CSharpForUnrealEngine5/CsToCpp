namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A helper for computing various properties from a SplineComponent.</summary>
[CppInclude("LearningAgentsHelpers.h")]
public partial class USplineComponentHelper : ULearningAgentsHelper {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new spline component helper to the given manager component.</summary>
	public static USplineComponentHelper AddSplineComponentHelper(ULearningAgentsManagerComponent InManagerComponent,FName Name/*=NAME_None*/) { return default; }
	///<summary>Gets the position on a spline closest to the provided position.</summary>
	public FVector GetNearestPositionOnSpline(int AgentId,USplineComponent SplineComponent,FVector Position,ESplineCoordinateSpace CoordinateSpace/*=ESplineCoordinateSpace.World*/) { return default; }
	///<summary>Gets the distance along a spline closest to the provided position.</summary>
	public float GetDistanceAlongSplineAtPosition(int AgentId,USplineComponent SplineComponent,FVector Position,ESplineCoordinateSpace CoordinateSpace/*=ESplineCoordinateSpace.World*/) { return default; }
	///<summary>Gets the position along a spline at the given distance.</summary>
	public FVector GetPositionAtDistanceAlongSpline(int AgentId,USplineComponent SplineComponent,float DistanceAlongSpline,ESplineCoordinateSpace CoordinateSpace/*=ESplineCoordinateSpace.World*/) { return default; }
	///<summary>Gets the direction along a spline at the given distance.</summary>
	public FVector GetDirectionAtDistanceAlongSpline(int AgentId,USplineComponent SplineComponent,float DistanceAlongSpline,ESplineCoordinateSpace CoordinateSpace/*=ESplineCoordinateSpace.World*/) { return default; }
	///<summary>Gets the proportion along a spline in the range 0-1 for a given distance.</summary>
	public float GetProportionAlongSpline(int AgentId,USplineComponent SplineComponent,float DistanceAlongSpline) { return default; }
	///<summary>Gets the proportion along a spline encoded as an angle between -180 and 180 degrees for a given distance.</summary>
	public float GetProportionAlongSplineAsAngle(int AgentId,USplineComponent SplineComponent,float DistanceAlongSpline) { return default; }
	///<summary>Gets an array of positions sampled along a spline between some starting and stopping distance. Deals properly</summary>
	public void GetPositionsAlongSpline(TArray<FVector> OutPositions,int AgentId,USplineComponent SplineComponent,int PositionNum,float StartDistanceAlongSpline,float StopDistanceAlongSpline,ESplineCoordinateSpace CoordinateSpace/*=ESplineCoordinateSpace.World*/) {}
	///<summary>Gets the velocity a point is traveling along a spline.</summary>
	public float GetVelocityAlongSpline(int AgentId,USplineComponent SplineComponent,FVector Position,FVector Velocity,float FiniteDifferenceDelta/*=10.0f*/,ESplineCoordinateSpace CoordinateSpace/*=ESplineCoordinateSpace.World*/) { return default; }
}
