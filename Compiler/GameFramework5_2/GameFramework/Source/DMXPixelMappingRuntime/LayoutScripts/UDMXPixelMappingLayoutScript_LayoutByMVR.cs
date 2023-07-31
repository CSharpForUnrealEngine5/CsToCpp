#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Arranges the components given their coordinates in the DMX Library&#39;s MVR specs</summary>
[CppInclude("LayoutScripts/DMXPixelMappingLayoutScript_LayoutByMVR.h")]
public partial class UDMXPixelMappingLayoutScript_LayoutByMVR : UDMXPixelMappingLayoutScript {
	///<summary>Which axis or axes are projected to the Pixel Mapping Layout</summary>
	public EDMXPixelMappingMVRProjectionPlane ProjectionPlane;
	///<summary>Margin of the MVR fixtures, in centimeters</summary>
	public FMargin MarginCentimeters;
	///<summary>Size each component should take, in pixels</summary>
	public float ComponentSizePixels;
}
