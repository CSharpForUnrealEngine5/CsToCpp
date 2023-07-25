#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseTools/BaseBrushTool.h")]
///<summary>Standard properties for a Brush-type Tool</summary>
public partial class UBrushBaseProperties : UInteractiveToolPropertySet {
// BrushBaseProperties
	public float BrushSize;
	public bool bSpecifyRadius;
	public float BrushRadius;
	public float BrushStrength;
	public float BrushFalloffAmount;
	public bool bShowStrength;
	public bool bShowFalloff;
}
