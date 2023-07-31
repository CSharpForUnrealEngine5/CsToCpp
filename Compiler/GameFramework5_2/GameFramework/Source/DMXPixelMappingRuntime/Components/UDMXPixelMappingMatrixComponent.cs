#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DMX Matrix group component</summary>
[CppInclude("Components/DMXPixelMappingMatrixComponent.h")]
public partial class UDMXPixelMappingMatrixComponent : UDMXPixelMappingOutputComponent {
	///<summary>FixturePatchMatrixRef_DEPRECATED</summary>
	public FDMXEntityFixturePatchRef FixturePatchMatrixRef_DEPRECATED;
	///<summary>FixturePatchRef</summary>
	public FDMXEntityFixturePatchRef FixturePatchRef;
	///<summary>Sets which color space Pixel Mapping sends</summary>
	public UClass ColorSpaceClass;
	///<summary>The Color Space currently in use</summary>
	public UDMXPixelMappingColorSpace ColorSpace;
	///<summary>Modulators applied to the output before sending DMX</summary>
	public TArray<UClass> ModulatorClasses;
	///<summary>The actual modulator instances</summary>
	public TArray<UDMXModulator> Modulators;
	///<summary>CoordinateGrid</summary>
	public FIntPoint CoordinateGrid;
	///<summary>CellSize</summary>
	public FVector2D CellSize;
	///<summary>Distribution</summary>
	public EDMXPixelMappingDistribution Distribution;
	///<summary>Layout script for the children of this component (hidden in customizations and displayed in its own panel).</summary>
	public UDMXPixelMappingLayoutScript LayoutScript;
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
