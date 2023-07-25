#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshToVolumeTool.h")]
///<summary>Converts a mesh to a volume.</summary>
public partial class UMeshToVolumeTool : USingleSelectionMeshEditingTool {
// MeshToVolumeTool
	public UMeshToVolumeToolProperties Settings;
	public UOnAcceptHandleSourcesPropertiesSingle HandleSourcesProperties;
	public UPreviewMesh PreviewMesh;
	public ULineSetComponent VolumeEdgesSet;
}
