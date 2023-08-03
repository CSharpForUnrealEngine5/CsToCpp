#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Material Function is a collection of material expressions that can be reused in different materials</summary>
[CppInclude("Materials/MaterialFunction.h")]
public partial class UMaterialFunction : UMaterialFunctionInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Used in the material editor, points to the function asset being edited, which this function is just a preview for.</summary>
	public UMaterialFunction ParentFunction;
	///<summary>Description of the function which will be displayed as a tooltip wherever the function is used.</summary>
	public string Description;
	///<summary>Whether to list this function in the material function library, which is a window in the material editor that lists categorized functions.</summary>
	public bool bExposeToLibrary;
	///<summary>If true, parameters in this function will have a prefix added to their group name.</summary>
	public bool bPrefixParameterNames;
	///<summary>bEnableExecWire</summary>
	public bool bEnableExecWire;
	///<summary>bEnableNewHLSLGenerator</summary>
	public bool bEnableNewHLSLGenerator;
	///<summary>Categories that this function belongs to in the material function library.</summary>
	public TArray<string> LibraryCategories_DEPRECATED;
	///<summary>Categories that this function belongs to in the material function library.</summary>
	public TArray<string> LibraryCategoriesText;
	///<summary>PreviewMaterial</summary>
	public UMaterial PreviewMaterial;
	///<summary>DependentFunctionExpressionCandidates</summary>
	public TArray<UMaterialExpressionMaterialFunctionCall> DependentFunctionExpressionCandidates;
	///<summary>Determines the blend mode when previewing a material function.</summary>
	public EBlendMode PreviewBlendMode;
	///<summary>Transient flag used to track re-entrance in recursive functions like IsDependent.</summary>
	public bool bReentrantFlag;
	///<summary>FunctionExpressions_DEPRECATED</summary>
	public TArray<UMaterialExpression> FunctionExpressions_DEPRECATED;
	///<summary>FunctionEditorComments_DEPRECATED</summary>
	public TArray<UMaterialExpressionComment> FunctionEditorComments_DEPRECATED;
	///<summary>ExpressionExecBegin_DEPRECATED</summary>
	public UMaterialExpressionExecBegin ExpressionExecBegin_DEPRECATED;
	///<summary>ExpressionExecEnd_DEPRECATED</summary>
	public UMaterialExpressionExecEnd ExpressionExecEnd_DEPRECATED;
}
