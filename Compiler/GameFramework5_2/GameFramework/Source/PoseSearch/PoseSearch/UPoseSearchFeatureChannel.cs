namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Feature channels interface</summary>
[CppInclude("PoseSearch/PoseSearchFeatureChannel.h")]
public partial class UPoseSearchFeatureChannel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ChannelDataOffset</summary>
	public int ChannelDataOffset;
	///<summary>ChannelCardinality</summary>
	public int ChannelCardinality;
}
