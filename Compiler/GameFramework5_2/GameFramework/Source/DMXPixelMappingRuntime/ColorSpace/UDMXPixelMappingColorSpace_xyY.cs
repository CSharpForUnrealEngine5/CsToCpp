namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ColorSpace/DMXPixelMappingColorSpace_xyY.h")]
public partial class UDMXPixelMappingColorSpace_xyY : UDMXPixelMappingColorSpace {
	public static UClass StaticClass() {return default;}
	///<summary>Attribute sent for x</summary>
	public FDMXAttributeName XAttribute;
	///<summary>Attribute sent for y</summary>
	public FDMXAttributeName YAttribute;
	///<summary>Attribute sent for Y</summary>
	public FDMXAttributeName LuminanceAttribute;
	///<summary>Min Luminance</summary>
	public float MinLuminance;
	///<summary>Max Luminance</summary>
	public float MaxLuminance;
}
