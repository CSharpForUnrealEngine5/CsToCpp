namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchFeatureChannel_Trajectory.h")]
public partial class UPoseSearchFeatureChannel_Trajectory : UPoseSearchFeatureChannel_GroupBase {
	public static UClass StaticClass() {return default;}
	///<summary>Weight</summary>
	public float Weight;
	///<summary>Samples</summary>
	public TArray<FPoseSearchTrajectorySample> Samples;
	///<summary>SubChannels</summary>
	public TArray<UPoseSearchFeatureChannel> SubChannels;
}
