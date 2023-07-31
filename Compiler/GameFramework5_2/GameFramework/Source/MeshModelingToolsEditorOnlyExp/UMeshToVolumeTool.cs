#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a mesh to a volume.</summary>
[CppInclude("MeshToVolumeTool.h")]
public partial class UMeshToVolumeTool : USingleSelectionMeshEditingTool {
	///<summary>Settings</summary>
	public UMeshToVolumeToolProperties Settings;
	///<summary>HandleSourcesProperties</summary>
	public UOnAcceptHandleSourcesPropertiesSingle HandleSourcesProperties;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>VolumeEdgesSet</summary>
	public ULineSetComponent VolumeEdgesSet;
}
