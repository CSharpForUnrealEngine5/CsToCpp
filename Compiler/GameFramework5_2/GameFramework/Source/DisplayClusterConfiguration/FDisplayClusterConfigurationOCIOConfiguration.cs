#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* OCIO configuration structure.</summary>
[CppInclude("DisplayClusterConfigurationTypes_OCIO.h")]
public partial struct FDisplayClusterConfigurationOCIOConfiguration {
	public bool bIsEnabled;
	public FOpenColorIODisplayConfiguration OCIOConfiguration_DEPRECATED;
	public FOpenColorIOColorConversionSettings ColorConfiguration;
}
