#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_OCIO.h")]
///<summary>* OCIO profile structure. Can be configured for viewports or cluster nodes.</summary>
public partial struct FDisplayClusterConfigurationOCIOProfile {
// DisplayClusterConfigurationOCIOProfile
	public bool bIsEnabled;
	public FOpenColorIODisplayConfiguration OCIOConfiguration_DEPRECATED;
	public TArray<string> ApplyOCIOToObjects;
	public FOpenColorIOColorConversionSettings ColorConfiguration;
}
