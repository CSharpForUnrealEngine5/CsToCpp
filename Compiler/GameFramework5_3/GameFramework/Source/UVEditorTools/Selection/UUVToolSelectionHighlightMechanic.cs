namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mechanic for highlighting mesh elements (usually selection) in the UV editor.</summary>
[CppInclude("Selection/UVToolSelectionHighlightMechanic.h")]
public partial class UUVToolSelectionHighlightMechanic : UInteractionMechanic {
	public static UClass StaticClass() {return default;}
	///<summary>UnwrapGeometryActor</summary>
	public APreviewGeometryActor UnwrapGeometryActor;
	///<summary>TriangleSetMaterial</summary>
	public UMaterialInstanceDynamic TriangleSetMaterial;
	///<summary>UnwrapStationaryGeometryActor</summary>
	public APreviewGeometryActor UnwrapStationaryGeometryActor;
	///<summary>LivePreviewGeometryActor</summary>
	public APreviewGeometryActor LivePreviewGeometryActor;
}
