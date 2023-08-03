#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for tools that do things with a mesh boundary. Provides ability to select mesh boundaries</summary>
[CppInclude("MeshBoundaryToolBase.h")]
public partial class UMeshBoundaryToolBase : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>SelectionMechanic</summary>
	public UPolygonSelectionMechanic SelectionMechanic;
}
