namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ColorSpace/DMXPixelMappingColorSpace_xyY.h")]
public partial class UDMXPixelMappingColorSpace_xyY : UDMXPixelMappingColorSpace {
	public static UClass StaticClass() {return default;}
	///<summary>Attribute sent for x</summary>
	public FDMXAttributeName XAttribute;
	///<summary>Attribute sent for y</summary>
	public FDMXAttributeName YAttribute;
	///<summary>Sets the range of the xyY color space. A value of 1.0 corresponds to the CIE 1931 xyY .</summary>
	public float ColorSpaceRange;
	///<summary>Attribute sent for Y</summary>
	public FDMXAttributeName LuminanceAttribute;
	///<summary>Min Luminance</summary>
	public float MinLuminance;
	///<summary>Max Luminance</summary>
	public float MaxLuminance;
}
