namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Identifies an OCIO Display look configuration</summary>
[CppInclude("OpenColorIOColorSpace.h")]
public partial struct FOpenColorIODisplayConfiguration {
	public bool bIsEnabled;
	public FOpenColorIOColorConversionSettings ColorConfiguration;
}
