#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionGIReplace.h")]
public partial class UMaterialExpressionGIReplace : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Used for direct lighting computations e.g. real-time shaders</summary>
	public FExpressionInput Default;
	///<summary>Used for baked indirect lighting e.g. Lightmass</summary>
	public FExpressionInput StaticIndirect;
	///<summary>Used for dynamic indirect lighting e.g. Light Propagation Volumes</summary>
	public FExpressionInput DynamicIndirect;
}
