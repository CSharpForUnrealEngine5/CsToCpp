#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for Pixel Mapping Color Spaces.</summary>
[CppInclude("ColorSpace/DMXPixelMappingColorSpace.h")]
public partial class UDMXPixelMappingColorSpace : UObject {
	///<summary>When checked, uses Unreal Working Color Space for input conversion, otherwise, assumes the input is sRGB</summary>
	public bool bUseWorkingColorSpaceForInput;
}
