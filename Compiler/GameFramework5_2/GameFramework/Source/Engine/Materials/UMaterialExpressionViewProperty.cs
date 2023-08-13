namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionViewProperty.h")]
public partial class UMaterialExpressionViewProperty : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>View input property to be accessed</summary>
	public EMaterialExposedViewProperty Property;
}
