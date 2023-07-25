#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BspConversionTool.h")]
public partial class UBspConversionToolProperties : UInteractiveToolPropertySet {
// BspConversionToolProperties
	public EBspConversionMode ConversionMode;
	public bool bIncludeVolumes;
	public bool bRemoveConvertedVolumes;
	public bool bExplicitSubtractiveBrushSelection;
	public bool bRemoveConvertedSubtractiveBrushes;
	public bool bCacheBrushes;
	public bool bShowPreview;
}
