#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenColorIOColorSpace.h")]
///<summary>Identifies a OCIO ColorSpace conversion.</summary>
public partial struct FOpenColorIOColorConversionSettings {
// OpenColorIOColorConversionSettings
	public UOpenColorIOConfiguration ConfigurationSource;
	public FOpenColorIOColorSpace SourceColorSpace;
	public FOpenColorIOColorSpace DestinationColorSpace;
	public FOpenColorIODisplayView DestinationDisplayView;
	public EOpenColorIOViewTransformDirection DisplayViewDirection;
}
