namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DynamicMeshSculptTool.h")]
public partial class UDynamicMeshBrushSculptProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>This is a dupe of the bool in the tool class.  I needed it here so it could be checked as an EditCondition</summary>
	public bool bIsRemeshingEnabled;
	///<summary>Primary Brush Mode</summary>
	public EDynamicMeshSculptBrushType PrimaryBrushType;
	///<summary>Strength of the Primary Brush</summary>
	public float PrimaryBrushSpeed;
	///<summary>If true, try to preserve the shape of the UV/3D mapping. This will limit Smoothing and Remeshing in some cases.</summary>
	public bool bPreserveUVFlow;
	///<summary>When Freeze Target is toggled on, the Brush Target Surface will be Frozen in its current state, until toggled off. Brush strokes will be applied relative to the Target Surface, for applicable Brushes</summary>
	public bool bFreezeTarget;
	///<summary>Strength of Shift-to-Smooth Brushing and Smoothing Brush</summary>
	public float SmoothBrushSpeed;
	///<summary>If enabled, Remeshing is limited during Smoothing to avoid wiping out higher-density triangle areas</summary>
	public bool bDetailPreservingSmooth;
}
