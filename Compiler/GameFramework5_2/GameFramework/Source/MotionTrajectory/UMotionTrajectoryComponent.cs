#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract component interface for the minimum Motion Trajectory prediction and history API</summary>
[CppInclude("MotionTrajectory.h")]
public partial class UMotionTrajectoryComponent : UActorComponent {
	///<summary>Interface for computing a trajectory prediction</summary>
	public  FTrajectorySampleRange GetTrajectory() { return default; }
	///<summary>Interface for computing a trajectory prediction with overridden component settings</summary>
	public  FTrajectorySampleRange GetTrajectoryWithSettings(FMotionTrajectorySettings Settings,bool bIncludeHistory) { return default; }
	///<summary>Retrieves the historical trajectory</summary>
	public  FTrajectorySampleRange GetHistory() { return default; }
	///<summary>Prediction trajectory simulation settings</summary>
	public FMotionTrajectorySettings PredictionSettings;
	///<summary>Historical trajectory settings</summary>
	public FMotionTrajectorySettings HistorySettings;
	///<summary>The trajectory sampling rate for prediction</summary>
	public int SampleRate;
	///<summary>The maximum number of trajectory samples retained by the internal history buffer</summary>
	public int MaxSamples;
	///<summary>Determines if GetTrajectory() will automatically combine history into the returned trajectory prediction (true)</summary>
	public bool bPredictionIncludesHistory;
	///<summary>Debug drawing options for the complete trajectory range</summary>
	public bool bDebugDrawTrajectory;
}
