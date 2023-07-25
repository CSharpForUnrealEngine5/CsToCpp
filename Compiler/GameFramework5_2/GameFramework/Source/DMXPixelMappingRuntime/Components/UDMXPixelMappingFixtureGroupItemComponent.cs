#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DMXPixelMappingFixtureGroupItemComponent.h")]
///<summary>A component that holds a single Fixture Patch in the Pixel Mapping, and actually sends DMX.</summary>
public partial class UDMXPixelMappingFixtureGroupItemComponent : UDMXPixelMappingOutputDMXComponent {
// DMXPixelMappingFixtureGroupItemComponent
	public FDMXEntityFixturePatchRef FixturePatchRef;
	public UClass ColorSpaceClass;
	public UDMXPixelMappingColorSpace ColorSpace;
	public TArray<UClass> ModulatorClasses;
	public TArray<UDMXModulator> Modulators;
	public EDMXColorMode ColorMode_DEPRECATED;
	public bool AttributeRExpose_DEPRECATED;
	public bool AttributeGExpose_DEPRECATED;
	public bool AttributeBExpose_DEPRECATED;
	public bool bMonochromeExpose_DEPRECATED;
	public bool AttributeRInvert_DEPRECATED;
	public bool AttributeGInvert_DEPRECATED;
	public bool AttributeBInvert_DEPRECATED;
	public bool bMonochromeInvert_DEPRECATED;
	public FDMXAttributeName AttributeR_DEPRECATED;
	public FDMXAttributeName AttributeG_DEPRECATED;
	public FDMXAttributeName AttributeB_DEPRECATED;
	public FDMXAttributeName MonochromeIntensity_DEPRECATED;
}
