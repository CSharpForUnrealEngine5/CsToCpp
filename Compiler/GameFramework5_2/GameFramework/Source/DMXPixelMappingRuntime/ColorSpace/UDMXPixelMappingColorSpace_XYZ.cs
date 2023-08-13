namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ColorSpace/DMXPixelMappingColorSpace_XYZ.h")]
public partial class UDMXPixelMappingColorSpace_XYZ : UDMXPixelMappingColorSpace {
	public static UClass StaticClass() {return default;}
	///<summary>Attribute sent for X</summary>
	public FDMXAttributeName XAttribute;
	///<summary>Attribute sent for Z</summary>
	public FDMXAttributeName ZAttribute;
	///<summary>Attribute sent for Y</summary>
	public FDMXAttributeName LuminanceAttribute;
	///<summary>Min Luminance</summary>
	public float MinLuminance;
	///<summary>Max Luminance</summary>
	public float MaxLuminance;
}
