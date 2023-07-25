#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TransformMeshesTool.h")]
public partial class UTransformMeshesTool : UMultiSelectionMeshEditingTool {
// TransformMeshesTool
	public UTransformMeshesToolProperties TransformProps;
	public TArray<FTransformMeshesTarget> ActiveGizmos;
	public UDragAlignmentMechanic DragAlignmentMechanic;
}
