namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BspConversionTool.h")]
public partial class UBspConversionToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>ConversionMode</summary>
	public EBspConversionMode ConversionMode;
	///<summary>Whether to consider BSP volumes to be valid conversion targets.</summary>
	public bool bIncludeVolumes;
	///<summary>Whether to remove any selected BSP volumes after using them to create a static mesh.</summary>
	public bool bRemoveConvertedVolumes;
	///<summary>Whether subtractive brushes have to be explicitly selected to be part of the conversion. If false, all</summary>
	public bool bExplicitSubtractiveBrushSelection;
	///<summary>Whether subtractive brushes used in a conversion should be removed. Only acts on explicitly selected</summary>
	public bool bRemoveConvertedSubtractiveBrushes;
	///<summary>Caches individual brush conversions in &quot;convert then combine&quot; mode during a single invocation of</summary>
	public bool bCacheBrushes;
	///<summary>Determines whether a dynamic preview is shown. Note that this introduces non-background computations</summary>
	public bool bShowPreview;
}
