namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties for a Brush-type Tool</summary>
[CppInclude("BaseTools/BaseBrushTool.h")]
public partial class UBrushBaseProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Relative size of brush</summary>
	public float BrushSize;
	///<summary>If true, ignore relative Brush Size and use explicit world Radius</summary>
	public bool bSpecifyRadius;
	///<summary>Radius of brush</summary>
	public float BrushRadius;
	///<summary>Strength of the brush (0.0 - 1.0)</summary>
	public float BrushStrength;
	///<summary>Amount of falloff to apply (0.0 - 1.0)</summary>
	public float BrushFalloffAmount;
	///<summary>If false, then BrushStrength will not be shown in DetailsView panels (otherwise no effect)</summary>
	public bool bShowStrength;
	///<summary>If false, then BrushFalloffAmount will not be shown in DetailsView panels (otherwise no effect)</summary>
	public bool bShowFalloff;
}
