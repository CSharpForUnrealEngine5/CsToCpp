#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSculptToolBase.h")]
public partial class USculptBrushProperties : UInteractiveToolPropertySet {
// SculptBrushProperties
	public FBrushToolRadius BrushSize;
	public float BrushFalloffAmount;
	public bool bShowFalloff;
	public float Depth;
	public bool bHitBackFaces;
	public float FlowRate;
	public float Spacing;
	public float Lazyness;
	public bool bShowPerBrushProps;
	public bool bShowLazyness;
	public bool bShowFlowRate;
	public bool bShowSpacing;
}
