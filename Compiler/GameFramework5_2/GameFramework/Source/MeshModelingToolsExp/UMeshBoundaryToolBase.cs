#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshBoundaryToolBase.h")]
///<summary>Base class for tools that do things with a mesh boundary. Provides ability to select mesh boundaries</summary>
public partial class UMeshBoundaryToolBase : USingleSelectionMeshEditingTool {
// MeshBoundaryToolBase
	public UPolygonSelectionMechanic SelectionMechanic;
}
