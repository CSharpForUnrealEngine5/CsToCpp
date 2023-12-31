namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionFontSample.h")]
public partial class UMaterialExpressionFontSample : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>font resource that will be sampled</summary>
	public UFont Font;
	///<summary>allow access to the various font pages</summary>
	public int FontTexturePage;
}
