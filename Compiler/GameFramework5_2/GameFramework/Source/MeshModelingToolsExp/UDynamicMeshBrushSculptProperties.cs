#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DynamicMeshSculptTool.h")]
public partial class UDynamicMeshBrushSculptProperties : UInteractiveToolPropertySet {
// DynamicMeshBrushSculptProperties
	public bool bIsRemeshingEnabled;
	public EDynamicMeshSculptBrushType PrimaryBrushType;
	public float PrimaryBrushSpeed;
	public bool bPreserveUVFlow;
	public bool bFreezeTarget;
	public float SmoothBrushSpeed;
	public bool bDetailPreservingSmooth;
}
