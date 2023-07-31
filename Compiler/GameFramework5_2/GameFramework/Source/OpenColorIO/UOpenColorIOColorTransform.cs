#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object used to generate shader and LUTs from OCIO configuration file and contain required resource to make a color space transform.</summary>
[CppInclude("OpenColorIOColorTransform.h")]
public partial class UOpenColorIOColorTransform : UObject {
	///<summary>ConfigurationOwner</summary>
	public UOpenColorIOConfiguration ConfigurationOwner;
	///<summary>bIsDisplayViewType</summary>
	public bool bIsDisplayViewType;
	///<summary>SourceColorSpace</summary>
	public string SourceColorSpace;
	///<summary>DestinationColorSpace</summary>
	public string DestinationColorSpace;
	///<summary>Display</summary>
	public string Display;
	///<summary>View</summary>
	public string View;
	///<summary>DisplayViewDirection</summary>
	public EOpenColorIOViewTransformDirection DisplayViewDirection;
	///<summary>Note: This will be serialized when cooking. Otherwhise, it relies on raw data of the library and what&#39;s on DDC</summary>
	public TMap<int,UTexture> Textures;
}
