#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseTools/BaseBrushTool.h")]
///<summary>UBaseBrushTool implements standard brush-style functionality for an InteractiveTool.</summary>
public partial class UBaseBrushTool : UMeshSurfacePointTool {
// BaseBrushTool
	public UBrushBaseProperties BrushProperties;
	public bool bInBrushStroke;
	public float WorldToLocalScale;
	public FBrushStampData LastBrushStamp;
	public TSoftObjectPtr<UClass> PropertyClass;
	public UBrushStampIndicator BrushStampIndicator;
}
