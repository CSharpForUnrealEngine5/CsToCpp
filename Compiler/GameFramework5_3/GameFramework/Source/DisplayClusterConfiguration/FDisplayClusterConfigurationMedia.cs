namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Media settings for viewports and backbuffer</summary>
[CppInclude("DisplayClusterConfigurationTypes_Media.h")]
public partial struct FDisplayClusterConfigurationMedia {
	public bool bEnable;
	public FDisplayClusterConfigurationMediaInput MediaInput;
	public TArray<FDisplayClusterConfigurationMediaOutput> MediaOutputs;
	public string MediaSharingNode_DEPRECATED;
	public UMediaSource MediaSource;
	public UMediaOutput MediaOutput;
	public UDisplayClusterMediaOutputSynchronizationPolicy OutputSyncPolicy;
}
