#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexSculptTool.h")]
public partial class UVertexBrushSculptProperties : UInteractiveToolPropertySet {
// VertexBrushSculptProperties
	public EMeshVertexSculptBrushType PrimaryBrushType;
	public EMeshSculptFalloffType PrimaryFalloffType;
	public EMeshVertexSculptBrushFilterType BrushFilter;
	public bool bFreezeTarget;
	public TWeakObjectPtr<UMeshVertexSculptTool> Tool;
}
