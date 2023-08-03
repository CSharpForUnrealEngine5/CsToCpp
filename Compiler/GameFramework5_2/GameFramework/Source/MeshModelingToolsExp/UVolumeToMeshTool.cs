#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VolumeToMeshTool.h")]
public partial class UVolumeToMeshTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UVolumeToMeshToolProperties Settings;
	///<summary>OutputTypeProperties</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>TargetVolume</summary>
	public TLazyObjectPtr<AVolume> TargetVolume;
	///<summary>VolumeEdgesSet</summary>
	public ULineSetComponent VolumeEdgesSet;
}
