#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimToTextureInstancePlaybackHelpers.h")]
public partial class UAnimToTextureInstancePlaybackLibrary : UBlueprintFunctionLibrary {
	///<summary>SetupInstancedMeshComponent</summary>
	public static void SetupInstancedMeshComponent(UInstancedStaticMeshComponent InstancedMeshComponent,FAnimToTextureInstanceData InstanceData,int NumInstances) {}
	///<summary>BatchUpdateInstancedMeshComponent</summary>
	public static void BatchUpdateInstancedMeshComponent(UInstancedStaticMeshComponent InstancedMeshComponent,FAnimToTextureInstanceData InstanceData) {}
	///<summary>AllocateInstanceData</summary>
	public static void AllocateInstanceData(FAnimToTextureInstanceData InstanceData,int Count) {}
	///<summary>UpdateInstanceData</summary>
	public static bool UpdateInstanceData(FAnimToTextureInstanceData InstanceData,int InstanceIndex,FAnimToTextureInstancePlaybackData PlaybackData,FTransform Transform) { return default; }
	///<summary>GetInstancePlaybackData</summary>
	public static bool GetInstancePlaybackData(FAnimToTextureInstanceData InstanceData,int InstanceIndex,FAnimToTextureInstancePlaybackData InstancePlaybackData) { return default; }
	///<summary>GetInstanceTransform</summary>
	public static bool GetInstanceTransform(FAnimToTextureInstanceData InstanceData,int InstanceIndex,FTransform InstanceTransform) { return default; }
	///<summary>AnimStateFromDataAsset</summary>
	public static bool AnimStateFromDataAsset(UAnimToTextureDataAsset DataAsset,int StateIndex,FAnimToTextureAnimState AnimState) { return default; }
}
