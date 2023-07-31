#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh render state structure.</summary>
[CppInclude("BaseGizmos/GizmoElementRenderState.h")]
public partial struct FGizmoElementMeshRenderStateAttributes {
	public FGizmoElementMaterialAttribute Material;
	public FGizmoElementMaterialAttribute HoverMaterial;
	public FGizmoElementMaterialAttribute InteractMaterial;
	public FGizmoElementColorAttribute VertexColor;
	public FGizmoElementColorAttribute HoverVertexColor;
	public FGizmoElementColorAttribute InteractVertexColor;
}
