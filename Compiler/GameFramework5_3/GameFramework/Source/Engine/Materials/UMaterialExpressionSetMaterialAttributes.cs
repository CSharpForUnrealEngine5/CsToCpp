namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSetMaterialAttributes.h")]
public partial class UMaterialExpressionSetMaterialAttributes : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Inputs</summary>
	public TArray<FExpressionInput> Inputs;
	///<summary>AttributeSetTypes</summary>
	public TArray<FGuid> AttributeSetTypes;
}
