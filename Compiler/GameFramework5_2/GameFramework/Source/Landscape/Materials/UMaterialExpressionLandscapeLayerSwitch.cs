namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionLandscapeLayerSwitch.h")]
public partial class UMaterialExpressionLandscapeLayerSwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>LayerUsed</summary>
	public FExpressionInput LayerUsed;
	///<summary>LayerNotUsed</summary>
	public FExpressionInput LayerNotUsed;
	///<summary>ParameterName</summary>
	public string ParameterName;
	///<summary>PreviewUsed</summary>
	public bool PreviewUsed;
}
