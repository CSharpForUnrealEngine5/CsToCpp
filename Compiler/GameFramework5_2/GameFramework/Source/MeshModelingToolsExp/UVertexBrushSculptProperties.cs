#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexSculptTool.h")]
public partial class UVertexBrushSculptProperties : UInteractiveToolPropertySet {
	///<summary>Primary Brush Mode</summary>
	public EMeshVertexSculptBrushType PrimaryBrushType;
	///<summary>Primary Brush Falloff Type, multiplied by Alpha Mask where applicable</summary>
	public EMeshSculptFalloffType PrimaryFalloffType;
	///<summary>Filter applied to Stamp Region Triangles, based on first Stroke Stamp</summary>
	public EMeshVertexSculptBrushFilterType BrushFilter;
	///<summary>When Freeze Target is toggled on, the Brush Target Surface will be Frozen in its current state, until toggled off. Brush strokes will be applied relative to the Target Surface, for applicable Brushes</summary>
	public bool bFreezeTarget;
	///<summary>parent ref required for details customization</summary>
	public TWeakObjectPtr<UMeshVertexSculptTool> Tool;
}
