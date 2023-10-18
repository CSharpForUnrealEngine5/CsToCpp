namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionComponentMask.h")]
public partial class UMaterialExpressionComponentMask : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
	///<summary>R</summary>
	public bool R;
	///<summary>G</summary>
	public bool G;
	///<summary>B</summary>
	public bool B;
	///<summary>A</summary>
	public bool A;
}
