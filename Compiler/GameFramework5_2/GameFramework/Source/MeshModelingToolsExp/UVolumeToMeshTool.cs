#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VolumeToMeshTool.h")]
public partial class UVolumeToMeshTool : UInteractiveTool {
// VolumeToMeshTool
	public UVolumeToMeshToolProperties Settings;
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	public UPreviewMesh PreviewMesh;
	public TLazyObjectPtr<AVolume> TargetVolume;
	public ULineSetComponent VolumeEdgesSet;
}
