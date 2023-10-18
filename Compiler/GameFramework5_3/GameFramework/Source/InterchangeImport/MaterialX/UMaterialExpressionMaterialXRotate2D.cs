namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material expression that rotates a vector2 value about the origin in 2D.</summary>
[CppInclude("MaterialX/MaterialExpressions/MaterialExpressionRotate2D.h")]
public partial class UMaterialExpressionMaterialXRotate2D : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
	///<summary>RotationAngle in degrees. Defaults to &#39;ConstRotationAngle&#39; if not specified</summary>
	public FExpressionInput RotationAngle;
	///<summary>only used if RotationAngle is not hooked up</summary>
	public float ConstRotationAngle;
}
