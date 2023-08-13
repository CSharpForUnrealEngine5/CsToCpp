namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Transform Meshes operation</summary>
[CppInclude("TransformMeshesTool.h")]
public partial class UTransformMeshesToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Transformation Mode controls the overall behavior of the Gizmos in the Tool</summary>
	public ETransformMeshesTransformMode TransformMode;
	///<summary>When true, transformations are applied to the Instances of any Instanced Components (eg InstancedStaticMeshComponent) instead of to the Components</summary>
	public bool bApplyToInstances;
	///<summary>When true, the Gizmo can be moved independently without affecting objects. This allows the Gizmo to be repositioned before transforming.</summary>
	public bool bSetPivotMode;
	///<summary>When Snap-Dragging is enabled, you can Click-drag starting on the target objects to reposition them relative to the rest of the scene</summary>
	public bool bEnableSnapDragging;
	///<summary>Which point on the object being Snap-Dragged to use as the &quot;Source&quot; point</summary>
	public ETransformMeshesSnapDragSource SnapDragSource;
	///<summary>How the object being Snap-Dragged should be rotated relative to the Source point location and Hit Surface normal</summary>
	public ETransformMeshesSnapDragRotationMode RotationMode;
	///<summary>internal, used to control visibility of Instance settings</summary>
	public bool bHaveInstances;
}
