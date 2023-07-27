#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionFunctionInput.h")]
public partial class UMaterialExpressionFunctionInput : UMaterialExpression {
// MaterialExpressionFunctionInput
	public FExpressionInput Preview;
	public string InputName;
	public string Description;
	public FGuid Id;
	public EFunctionInputType InputType;
	public FVector4f PreviewValue;
	public bool bUsePreviewValueAsDefault;
	public int SortPriority;
	public bool bCompilingFunctionPreview;
}
