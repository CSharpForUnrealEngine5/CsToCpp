#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_OCIO.h")]
///<summary>* OCIO configuration structure.</summary>
public partial struct FDisplayClusterConfigurationOCIOConfiguration {
// DisplayClusterConfigurationOCIOConfiguration
	public bool bIsEnabled;
	public FOpenColorIODisplayConfiguration OCIOConfiguration_DEPRECATED;
	public FOpenColorIOColorConversionSettings ColorConfiguration;
}
