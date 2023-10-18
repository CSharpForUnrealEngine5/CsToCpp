namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>this channel is mainly for debug purposes to augment the features data with the sampling time (default weight is set to zero to be irrelevant during searches)</summary>
[CppInclude("PoseSearchFeatureChannel_SamplingTime.h")]
public partial class UPoseSearchFeatureChannel_SamplingTime : UPoseSearchFeatureChannel {
	public static UClass StaticClass() {return default;}
	///<summary>Weight</summary>
	public float Weight;
	///<summary>TimeToMatch</summary>
	public float TimeToMatch;
}
