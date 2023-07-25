#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TransformMeshesTool.h")]
///<summary>Standard properties of the Transform Meshes operation</summary>
public partial class UTransformMeshesToolProperties : UInteractiveToolPropertySet {
// TransformMeshesToolProperties
	public ETransformMeshesTransformMode TransformMode;
	public bool bApplyToInstances;
	public bool bSetPivotMode;
	public bool bEnableSnapDragging;
	public ETransformMeshesSnapDragSource SnapDragSource;
	public ETransformMeshesSnapDragRotationMode RotationMode;
	public bool bHaveInstances;
}
