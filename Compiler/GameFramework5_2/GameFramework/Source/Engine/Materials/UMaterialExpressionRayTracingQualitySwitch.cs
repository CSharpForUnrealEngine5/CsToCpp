namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionRayTracingQualitySwitch.h")]
public partial class UMaterialExpressionRayTracingQualitySwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Used for standard rasterization</summary>
	public FExpressionInput Normal;
	///<summary>Used for simplified ray trace eval</summary>
	public FExpressionInput RayTraced;
}
