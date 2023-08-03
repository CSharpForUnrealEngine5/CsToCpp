#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionTrajectoryLibrary.h")]
public partial class UMotionTrajectoryBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Removes the Z axis motion contribution from a trajectory range</summary>
	public static FTrajectorySampleRange FlattenTrajectory2D(FTrajectorySampleRange Trajectory) { return default; }
	///<summary>Rotates the trajectory</summary>
	public static FTrajectorySampleRange RotateTrajectory(FTrajectorySampleRange Trajectory,FQuat Rotation) { return default; }
	///<summary>Rotates the trajectory to make it relative to the component specified as a parameter</summary>
	public static FTrajectorySampleRange MakeTrajectoryRelativeToComponent(FTrajectorySampleRange ActorTrajectory,USceneComponent Component) { return default; }
	///<summary>Projects trajectory samples onto a defined set of allowed directions</summary>
	public static void DebugDrawTrajectory(AActor Actor,FTransform WorldTransform,FTrajectorySampleRange Trajectory,FLinearColor PredictionColor/*=new FLinearColor(0.0f,1.0f,0.0f)*/,FLinearColor HistoryColor/*=new FLinearColor(0.0f,0.0f,1.0f)*/,float TransformScale/*=10.0f*/,float TransformThickness/*=2.0f*/,float ArrowScale/*=0.025f*/,float ArrowSize/*=40.0f*/,float ArrowThickness/*=2.0f*/) {}
	///<summary>Returns true if the furthest future sample, at the end of the trajectory, has velocity magnitude below</summary>
	public static bool IsStoppingTrajectory(FTrajectorySampleRange Trajectory,float MoveMinSpeed/*=1.0f*/,float IdleMaxSpeed/*=0.0f*/) { return default; }
	///<summary>Returns true if the furthest past sample, at the beginning of the trajectory, has velocity magnitude below</summary>
	public static bool IsStartingTrajectory(FTrajectorySampleRange Trajectory,float MoveMinSpeed/*=1.0f*/,float IdleMaxSpeed/*=0.0f*/) { return default; }
	///<summary>Returns true if the furthest future sample, at the end of the trajectory, and the present sample, have a velocity</summary>
	public static bool IsConstantSpeedTrajectory(FTrajectorySampleRange Trajectory,float Speed/*=0.0f*/,float Tolerance/*=0.001f*/) { return default; }
}
