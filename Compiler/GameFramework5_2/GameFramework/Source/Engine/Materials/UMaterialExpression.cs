#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpression.h")]
public partial class UMaterialExpression : UObject {
	///<summary>MaterialExpressionEditorX</summary>
	public int MaterialExpressionEditorX;
	///<summary>MaterialExpressionEditorY</summary>
	public int MaterialExpressionEditorY;
	///<summary>Expression&#39;s Graph representation</summary>
	public UEdGraphNode GraphNode;
	///<summary>If exists, expresssion containing this expression within its subgraph.</summary>
	public UMaterialExpression SubgraphExpression;
	///<summary>GUID to uniquely identify this node, to help the tutorials out</summary>
	public FGuid MaterialExpressionGuid;
	///<summary>The material that this expression is currently being compiled in.</summary>
	public UMaterial Material;
	///<summary>The material function that this expression is being used with, if any.</summary>
	public UMaterialFunction Function;
	///<summary>A description that level designers can add (shows in the material editor UI).</summary>
	public string Desc;
	///<summary>Set to true by RecursiveUpdateRealtimePreview() if the expression&#39;s preview needs to be updated in realtime in the material editor.</summary>
	public bool bRealtimePreview;
	///<summary>If true, we should update the preview next render. This is set when changing bRealtimePreview.</summary>
	public bool bNeedToUpdatePreview;
	///<summary>Indicates that this is a &#39;parameter&#39; type of expression and should always be loaded (ie not cooked away) because we might want the default parameter.</summary>
	public bool bIsParameterExpression;
	///<summary>If true, the comment bubble will be visible in the graph editor</summary>
	public bool bCommentBubbleVisible;
	///<summary>If true, use the output name as the label for the pin</summary>
	public bool bShowOutputNameOnPin;
	///<summary>If true, changes the pin color to match the output mask</summary>
	public bool bShowMaskColorsOnPin;
	///<summary>If true, do not render the preview window for the expression</summary>
	public bool bHidePreviewWindow;
	///<summary>If true, show a collapsed version of the node</summary>
	public bool bCollapsed;
	///<summary>Whether the node represents an input to the shader or not.  Used to color the node&#39;s background.</summary>
	public bool bShaderInputData;
	///<summary>Whether to draw the expression&#39;s inputs.</summary>
	public bool bShowInputs;
	///<summary>Whether to draw the expression&#39;s outputs.</summary>
	public bool bShowOutputs;
	///<summary>Localized categories to sort this expression into...</summary>
	public TArray<string> MenuCategories;
	///<summary>The expression&#39;s outputs, which are set in default properties by derived classes.</summary>
	public TArray<FExpressionOutput> Outputs;
}
