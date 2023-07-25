#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionTrajectoryLibrary.h")]
public partial class UMotionTrajectoryBlueprintLibrary : UBlueprintFunctionLibrary {
// MotionTrajectoryBlueprintLibrary
	public FTrajectorySampleRange FlattenTrajectory2D(FTrajectorySampleRange Trajectory) { return default; }
	public FTrajectorySampleRange RotateTrajectory(FTrajectorySampleRange Trajectory,FQuat Rotation) { return default; }
	public FTrajectorySampleRange MakeTrajectoryRelativeToComponent(FTrajectorySampleRange ActorTrajectory,UObject Component) { return default; }
	public void DebugDrawTrajectory(UObject Actor,FTransform WorldTransform,FTrajectorySampleRange Trajectory,FLinearColor PredictionColor/*=new FLinearColor(0.0f,1.0f,0.0f)*/,FLinearColor HistoryColor/*=new FLinearColor(0.0f,0.0f,1.0f)*/,float TransformScale/*=10.0f*/,float TransformThickness/*=2.0f*/,float ArrowScale/*=0.025f*/,float ArrowSize/*=40.0f*/,float ArrowThickness/*=2.0f*/) {}
	public bool IsStoppingTrajectory(FTrajectorySampleRange Trajectory,float MoveMinSpeed/*=1.0f*/,float IdleMaxSpeed/*=0.0f*/) { return default; }
	public bool IsStartingTrajectory(FTrajectorySampleRange Trajectory,float MoveMinSpeed/*=1.0f*/,float IdleMaxSpeed/*=0.0f*/) { return default; }
	public bool IsConstantSpeedTrajectory(FTrajectorySampleRange Trajectory,float Speed/*=0.0f*/,float Tolerance/*=0.001f*/) { return default; }
}
