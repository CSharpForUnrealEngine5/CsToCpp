namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that holds a single Fixture Patch in the Pixel Mapping, and actually sends DMX.</summary>
[CppInclude("Components/DMXPixelMappingFixtureGroupItemComponent.h")]
public partial class UDMXPixelMappingFixtureGroupItemComponent : UDMXPixelMappingOutputDMXComponent {
	public static UClass StaticClass() {return default;}
	///<summary>ColorMode_DEPRECATED</summary>
	public EDMXColorMode ColorMode_DEPRECATED;
	///<summary>AttributeRExpose_DEPRECATED</summary>
	public bool AttributeRExpose_DEPRECATED;
	///<summary>AttributeGExpose_DEPRECATED</summary>
	public bool AttributeGExpose_DEPRECATED;
	///<summary>AttributeBExpose_DEPRECATED</summary>
	public bool AttributeBExpose_DEPRECATED;
	///<summary>bMonochromeExpose_DEPRECATED</summary>
	public bool bMonochromeExpose_DEPRECATED;
	///<summary>AttributeRInvert_DEPRECATED</summary>
	public bool AttributeRInvert_DEPRECATED;
	///<summary>AttributeGInvert_DEPRECATED</summary>
	public bool AttributeGInvert_DEPRECATED;
	///<summary>AttributeBInvert_DEPRECATED</summary>
	public bool AttributeBInvert_DEPRECATED;
	///<summary>bMonochromeInvert_DEPRECATED</summary>
	public bool bMonochromeInvert_DEPRECATED;
	///<summary>AttributeR_DEPRECATED</summary>
	public FDMXAttributeName AttributeR_DEPRECATED;
	///<summary>AttributeG_DEPRECATED</summary>
	public FDMXAttributeName AttributeG_DEPRECATED;
	///<summary>AttributeB_DEPRECATED</summary>
	public FDMXAttributeName AttributeB_DEPRECATED;
	///<summary>MonochromeIntensity_DEPRECATED</summary>
	public FDMXAttributeName MonochromeIntensity_DEPRECATED;
}
