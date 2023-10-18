namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionGetMaterialAttributes.h")]
public partial class UMaterialExpressionGetMaterialAttributes : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>MaterialAttributes</summary>
	public FMaterialAttributesInput MaterialAttributes;
	///<summary>AttributeGetTypes</summary>
	public TArray<FGuid> AttributeGetTypes;
}
