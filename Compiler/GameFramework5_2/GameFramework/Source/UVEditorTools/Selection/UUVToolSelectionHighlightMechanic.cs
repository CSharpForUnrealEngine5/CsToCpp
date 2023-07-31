#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mechanic for highlighting mesh elements (usually selection) in the UV editor.</summary>
[CppInclude("Selection/UVToolSelectionHighlightMechanic.h")]
public partial class UUVToolSelectionHighlightMechanic : UInteractionMechanic {
	///<summary>UnwrapGeometryActor</summary>
	public APreviewGeometryActor UnwrapGeometryActor;
	///<summary>TriangleSetMaterial</summary>
	public UMaterialInstanceDynamic TriangleSetMaterial;
	///<summary>UnwrapStationaryGeometryActor</summary>
	public APreviewGeometryActor UnwrapStationaryGeometryActor;
	///<summary>LivePreviewGeometryActor</summary>
	public APreviewGeometryActor LivePreviewGeometryActor;
}
