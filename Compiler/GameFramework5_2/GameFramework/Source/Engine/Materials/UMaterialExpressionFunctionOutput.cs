namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionFunctionOutput.h")]
public partial class UMaterialExpressionFunctionOutput : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>The output&#39;s name, which will be drawn on the connector in function call expressions that use this function.</summary>
	public string OutputName;
	///<summary>The output&#39;s description, which will be used as a tooltip on the connector in function call expressions that use this function.</summary>
	public string Description;
	///<summary>Controls where the output is displayed relative to the other outputs.</summary>
	public int SortPriority;
	///<summary>Stores the expression in the material function connected to this output.</summary>
	public FExpressionInput A;
	///<summary>Whether this output was previewed the last time this function was edited.</summary>
	public bool bLastPreviewed;
	///<summary>Id of this input, used to maintain references through name changes.</summary>
	public FGuid Id;
}
