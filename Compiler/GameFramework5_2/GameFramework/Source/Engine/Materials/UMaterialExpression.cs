#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpression.h")]
public partial class UMaterialExpression : UObject {
// MaterialExpression
	public int MaterialExpressionEditorX;
	public int MaterialExpressionEditorY;
	public UEdGraphNode GraphNode;
	public UMaterialExpression SubgraphExpression;
	public FGuid MaterialExpressionGuid;
	public UMaterial Material;
	public UMaterialFunction Function;
	public string Desc;
	public bool bRealtimePreview;
	public bool bNeedToUpdatePreview;
	public bool bIsParameterExpression;
	public bool bCommentBubbleVisible;
	public bool bShowOutputNameOnPin;
	public bool bShowMaskColorsOnPin;
	public bool bHidePreviewWindow;
	public bool bCollapsed;
	public bool bShaderInputData;
	public bool bShowInputs;
	public bool bShowOutputs;
	public TArray<string> MenuCategories;
	public TArray<FExpressionOutput> Outputs;
}
