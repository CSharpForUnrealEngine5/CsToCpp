namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Media settings for viewports and backbuffer</summary>
[CppInclude("DisplayClusterConfigurationTypes_Media.h")]
public partial struct FDisplayClusterConfigurationMedia {
	public bool bEnable;
	public UMediaSource MediaSource;
	public UMediaOutput MediaOutput;
	public string MediaSharingNode_DEPRECATED;
}
