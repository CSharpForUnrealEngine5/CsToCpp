#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UBaseBrushTool implements standard brush-style functionality for an InteractiveTool.</summary>
[CppInclude("BaseTools/BaseBrushTool.h")]
public partial class UBaseBrushTool : UMeshSurfacePointTool {
	///<summary>Properties that control brush size/etc</summary>
	public UBrushBaseProperties BrushProperties;
	///<summary>Set to true by Tool if user is currently in an active brush stroke</summary>
	public bool bInBrushStroke;
	///<summary>Uniform scale factor that scales from world space (where brush usually exists) to local space</summary>
	public float WorldToLocalScale;
	///<summary>Position of brush at last update (both during stroke and during Hover)</summary>
	public FBrushStampData LastBrushStamp;
	///<summary>PropertyClass</summary>
	public TSoftObjectPtr<UClass> PropertyClass;
	///<summary>BrushStampIndicator</summary>
	public UBrushStampIndicator BrushStampIndicator;
}
