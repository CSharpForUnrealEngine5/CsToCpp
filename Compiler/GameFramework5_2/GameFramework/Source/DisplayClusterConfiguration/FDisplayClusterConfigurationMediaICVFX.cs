namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Media settings for ICVFX cameras</summary>
[CppInclude("DisplayClusterConfigurationTypes_Media.h")]
public partial struct FDisplayClusterConfigurationMediaICVFX {
	public bool bEnable;
	public TArray<FDisplayClusterConfigurationMediaOutputGroup> MediaOutputGroups;
	public TArray<FDisplayClusterConfigurationMediaInputGroup> MediaInputGroups;
}
