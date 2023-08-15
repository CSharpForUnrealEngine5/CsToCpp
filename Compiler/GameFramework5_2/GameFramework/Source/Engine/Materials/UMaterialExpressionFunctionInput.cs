namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionFunctionInput.h")]
public partial class UMaterialExpressionFunctionInput : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Used for previewing when editing the function, or when bUsePreviewValueAsDefault is enabled.</summary>
	public FExpressionInput Preview;
	///<summary>The input&#39;s name, which will be drawn on the connector in function call expressions that use this function.</summary>
	public FName InputName;
	///<summary>The input&#39;s description, which will be used as a tooltip on the connector in function call expressions that use this function.</summary>
	public string Description;
	///<summary>Id of this input, used to maintain references through name changes.</summary>
	public FGuid Id;
	///<summary>Type of this input.</summary>
	public EFunctionInputType InputType;
	///<summary>Value used to preview this input when editing the material function.</summary>
	public FVector4f PreviewValue;
	///<summary>Whether to use the preview value or texture as the default value for this input.</summary>
	public bool bUsePreviewValueAsDefault;
	///<summary>Controls where the input is displayed relative to the other inputs.</summary>
	public int SortPriority;
	///<summary>true when this expression is being compiled in a function preview,</summary>
	public bool bCompilingFunctionPreview;
}
