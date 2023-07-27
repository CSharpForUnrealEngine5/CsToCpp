#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/LODManagerTool.h")]
///<summary>Mesh Attribute Editor Tool</summary>
public partial class ULODManagerTool : UMultiSelectionMeshEditingTool {
// LODManagerTool
	public ULODManagerLODProperties LODInfoProperties;
	public ULODManagerPreviewLODProperties LODPreviewProperties;
	public ULODManagerHiResSourceModelActions HiResSourceModelActions;
	public ULODManagerMaterialActions MaterialActions;
	public  void DeleteHiResSourceModel() {}
	public  void MoveHiResToLOD0() {}
	public  void RemoveUnreferencedMaterials() {}
	public UPreviewMesh LODPreview;
	public UPreviewGeometry LODPreviewLines;
}
