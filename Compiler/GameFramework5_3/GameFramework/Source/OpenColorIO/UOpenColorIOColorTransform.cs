namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object used to generate shader and LUTs from OCIO configuration file and contain required resource to make a color space transform.</summary>
[CppInclude("OpenColorIOColorTransform.h")]
public partial class UOpenColorIOColorTransform : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ConfigurationOwner_DEPRECATED</summary>
	public UOpenColorIOConfiguration ConfigurationOwner_DEPRECATED;
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
	///<summary>If the color space requires textures, this will contains the data to do the transform</summary>
	public TMap<int,UTexture> Textures;
	///<summary>Generated transform shader hash.</summary>
	public string GeneratedShaderHash;
	///<summary>Generated transform shader function.</summary>
	public string GeneratedShader;
}
