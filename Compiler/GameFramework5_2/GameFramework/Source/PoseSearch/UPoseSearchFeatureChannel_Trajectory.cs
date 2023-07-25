#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchFeatureChannel_Trajectory.h")]
public partial class UPoseSearchFeatureChannel_Trajectory : UPoseSearchFeatureChannel_GroupBase {
// PoseSearchFeatureChannel_Trajectory
	public float Weight;
	public TArray<FPoseSearchTrajectorySample> Samples;
	public TArray<UPoseSearchFeatureChannel> SubChannels;
}
