#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ColorSpace/DMXPixelMappingColorSpace_RGBCMY.h")]
public partial class UDMXPixelMappingColorSpace_RGBCMY : UDMXPixelMappingColorSpace {
	///<summary>The color space to use</summary>
	public EDMXPixelMappingOutputColorSpace_RGBCMY PixelMappingOutputColorSpace;
	///<summary>If set, converts Red to Cyan</summary>
	public bool bSendCyan;
	///<summary>If set, converts Green to Magenta</summary>
	public bool bSendMagenta;
	///<summary>If set, converts Blue to Yellow</summary>
	public bool bSendYellow;
	///<summary>Attribute sent for Red</summary>
	public FDMXAttributeName RedAttribute;
	///<summary>Attribute sent for Green</summary>
	public FDMXAttributeName GreenAttribute;
	///<summary>Attribute sent for Blue</summary>
	public FDMXAttributeName BlueAttribute;
	///<summary>Adds a Dimmer Attribute</summary>
	public EDMXPixelMappingLuminanceType_RGBCMY LuminanceType;
	///<summary>Attribute sent for the generated Luminance</summary>
	public FDMXAttributeName LuminanceAttribute;
	///<summary>Luminance used when Luminance Type is set to &#39;Set Value&#39;</summary>
	public float Luminance;
	///<summary>Min Luminance used when Luminance Type is set to &#39;From White&#39; or &#39;From Alpha&#39;</summary>
	public float MinLuminance;
	///<summary>Max Luminance used when Luminance Type is set to &#39;From White&#39; or &#39;From Alpha&#39;</summary>
	public float MaxLuminance;
}
