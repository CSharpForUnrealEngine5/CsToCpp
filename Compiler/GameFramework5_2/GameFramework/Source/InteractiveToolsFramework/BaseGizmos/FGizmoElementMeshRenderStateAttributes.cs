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
