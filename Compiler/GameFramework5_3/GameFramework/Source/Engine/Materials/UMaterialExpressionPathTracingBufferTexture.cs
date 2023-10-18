namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Path tracing buffer is only accessable in postprocess material.</summary>
[CppInclude("Materials/MaterialExpressionPathTracingBufferTexture.h")]
public partial class UMaterialExpressionPathTracingBufferTexture : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Ignored if not specified</summary>
	public FExpressionInput Coordinates;
	///<summary>Which path tracing buffer texture we want to make a lookup into.</summary>
	public EPathTracingBufferTextureId PathTracingBufferTextureId;
}
