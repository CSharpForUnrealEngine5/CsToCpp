#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenColorIOColorTransform.h")]
///<summary>Object used to generate shader and LUTs from OCIO configuration file and contain required resource to make a color space transform.</summary>
public partial class UOpenColorIOColorTransform : UObject {
// OpenColorIOColorTransform
	public UOpenColorIOConfiguration ConfigurationOwner;
	public bool bIsDisplayViewType;
	public string SourceColorSpace;
	public string DestinationColorSpace;
	public string Display;
	public string View;
	public EOpenColorIOViewTransformDirection DisplayViewDirection;
	public TMap<int,UTexture> Textures;
}
