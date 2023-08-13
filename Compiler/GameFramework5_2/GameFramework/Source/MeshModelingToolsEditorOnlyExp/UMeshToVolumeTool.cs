namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a mesh to a volume.</summary>
[CppInclude("MeshToVolumeTool.h")]
public partial class UMeshToVolumeTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UMeshToVolumeToolProperties Settings;
	///<summary>HandleSourcesProperties</summary>
	public UOnAcceptHandleSourcesPropertiesSingle HandleSourcesProperties;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>VolumeEdgesSet</summary>
	public ULineSetComponent VolumeEdgesSet;
}
