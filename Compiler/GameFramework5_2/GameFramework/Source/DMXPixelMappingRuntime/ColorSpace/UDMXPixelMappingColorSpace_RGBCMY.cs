#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ColorSpace/DMXPixelMappingColorSpace_RGBCMY.h")]
public partial class UDMXPixelMappingColorSpace_RGBCMY : UDMXPixelMappingColorSpace {
// DMXPixelMappingColorSpace_RGBCMY
	public EDMXPixelMappingOutputColorSpace_RGBCMY PixelMappingOutputColorSpace;
	public bool bSendCyan;
	public bool bSendMagenta;
	public bool bSendYellow;
	public FDMXAttributeName RedAttribute;
	public FDMXAttributeName GreenAttribute;
	public FDMXAttributeName BlueAttribute;
	public EDMXPixelMappingLuminanceType_RGBCMY LuminanceType;
	public FDMXAttributeName LuminanceAttribute;
	public float Luminance;
	public float MinLuminance;
	public float MaxLuminance;
}
