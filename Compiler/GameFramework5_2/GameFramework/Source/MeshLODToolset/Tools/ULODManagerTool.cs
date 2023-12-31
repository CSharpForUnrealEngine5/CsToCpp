namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Attribute Editor Tool</summary>
[CppInclude("Tools/LODManagerTool.h")]
public partial class ULODManagerTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>LODInfoProperties</summary>
	public ULODManagerLODProperties LODInfoProperties;
	///<summary>LODPreviewProperties</summary>
	public ULODManagerPreviewLODProperties LODPreviewProperties;
	///<summary>HiResSourceModelActions</summary>
	public ULODManagerHiResSourceModelActions HiResSourceModelActions;
	///<summary>MaterialActions</summary>
	public ULODManagerMaterialActions MaterialActions;
	///<summary>DeleteHiResSourceModel</summary>
	public void DeleteHiResSourceModel() {}
	///<summary>MoveHiResToLOD0</summary>
	public void MoveHiResToLOD0() {}
	///<summary>RemoveUnreferencedMaterials</summary>
	public void RemoveUnreferencedMaterials() {}
	///<summary>LODPreview</summary>
	public UPreviewMesh LODPreview;
	///<summary>LODPreviewLines</summary>
	public UPreviewGeometry LODPreviewLines;
}
