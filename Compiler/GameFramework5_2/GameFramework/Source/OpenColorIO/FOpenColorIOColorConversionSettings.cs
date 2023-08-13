namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Identifies a OCIO ColorSpace conversion.</summary>
[CppInclude("OpenColorIOColorSpace.h")]
public partial struct FOpenColorIOColorConversionSettings {
	public UOpenColorIOConfiguration ConfigurationSource;
	public FOpenColorIOColorSpace SourceColorSpace;
	public FOpenColorIOColorSpace DestinationColorSpace;
	public FOpenColorIODisplayView DestinationDisplayView;
	public EOpenColorIOViewTransformDirection DisplayViewDirection;
}
