namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A container of ordered trajectory samples and associated sampling rate</summary>
[CppInclude("Animation/MotionTrajectoryTypes.h")]
public partial struct FTrajectorySampleRange {
	public TArray<FTrajectorySample> Samples;
}
