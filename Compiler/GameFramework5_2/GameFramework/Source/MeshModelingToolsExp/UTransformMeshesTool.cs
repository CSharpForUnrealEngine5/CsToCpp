namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TransformMeshesTool.h")]
public partial class UTransformMeshesTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>TransformProps</summary>
	public UTransformMeshesToolProperties TransformProps;
	///<summary>ActiveGizmos</summary>
	public TArray<FTransformMeshesTarget> ActiveGizmos;
	///<summary>DragAlignmentMechanic</summary>
	public UDragAlignmentMechanic DragAlignmentMechanic;
}
