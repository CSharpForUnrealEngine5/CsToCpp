#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Selection/UVToolSelectionHighlightMechanic.h")]
///<summary>Mechanic for highlighting mesh elements (usually selection) in the UV editor.</summary>
public partial class UUVToolSelectionHighlightMechanic : UInteractionMechanic {
// UVToolSelectionHighlightMechanic
	public APreviewGeometryActor UnwrapGeometryActor;
	public UMaterialInstanceDynamic TriangleSetMaterial;
	public APreviewGeometryActor UnwrapStationaryGeometryActor;
	public APreviewGeometryActor LivePreviewGeometryActor;
}
