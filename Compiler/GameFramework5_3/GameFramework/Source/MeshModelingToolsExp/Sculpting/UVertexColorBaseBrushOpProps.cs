namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshVertexPaintBrushOps.h")]
public partial class UVertexColorBaseBrushOpProps : UMeshSculptBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the Brush</summary>
	public float Strength;
	///<summary>Amount of falloff to apply</summary>
	public float Falloff;
	///<summary>BlendMode</summary>
	public EVertexColorPaintBrushOpBlendMode BlendMode;
	///<summary>If bApplyFalloff is disabled, 1.0 is used as &quot;falloff&quot; for all vertices</summary>
	public bool bApplyFalloff;
}
