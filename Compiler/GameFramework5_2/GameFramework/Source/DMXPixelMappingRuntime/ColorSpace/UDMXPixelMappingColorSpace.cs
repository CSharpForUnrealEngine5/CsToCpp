namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for Pixel Mapping Color Spaces.</summary>
[CppInclude("ColorSpace/DMXPixelMappingColorSpace.h")]
public partial class UDMXPixelMappingColorSpace : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>When checked, uses Unreal Working Color Space for input conversion, otherwise, assumes the input is sRGB</summary>
	public bool bUseWorkingColorSpaceForInput;
}
