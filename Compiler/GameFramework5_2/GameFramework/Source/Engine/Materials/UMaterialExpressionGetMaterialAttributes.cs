#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
