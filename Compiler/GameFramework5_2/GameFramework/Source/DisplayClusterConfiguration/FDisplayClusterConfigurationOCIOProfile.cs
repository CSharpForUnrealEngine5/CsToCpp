#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* OCIO profile structure. Can be configured for viewports or cluster nodes.</summary>
[CppInclude("DisplayClusterConfigurationTypes_OCIO.h")]
public partial struct FDisplayClusterConfigurationOCIOProfile {
	public bool bIsEnabled;
	public FOpenColorIODisplayConfiguration OCIOConfiguration_DEPRECATED;
	public TArray<string> ApplyOCIOToObjects;
	public FOpenColorIOColorConversionSettings ColorConfiguration;
}
