#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimToTextureInstancePlaybackHelpers.h")]
public partial class UAnimToTextureInstancePlaybackLibrary : UBlueprintFunctionLibrary {
// AnimToTextureInstancePlaybackLibrary
	public static void SetupInstancedMeshComponent(UInstancedStaticMeshComponent InstancedMeshComponent,FAnimToTextureInstanceData InstanceData,int NumInstances) {}
	public static void BatchUpdateInstancedMeshComponent(UInstancedStaticMeshComponent InstancedMeshComponent,FAnimToTextureInstanceData InstanceData) {}
	public static void AllocateInstanceData(FAnimToTextureInstanceData InstanceData,int Count) {}
	public static bool UpdateInstanceData(FAnimToTextureInstanceData InstanceData,int InstanceIndex,FAnimToTextureInstancePlaybackData PlaybackData,FTransform Transform) { return default; }
	public static bool GetInstancePlaybackData(FAnimToTextureInstanceData InstanceData,int InstanceIndex,FAnimToTextureInstancePlaybackData InstancePlaybackData) { return default; }
	public static bool GetInstanceTransform(FAnimToTextureInstanceData InstanceData,int InstanceIndex,FTransform InstanceTransform) { return default; }
	public static bool AnimStateFromDataAsset(UAnimToTextureDataAsset DataAsset,int StateIndex,FAnimToTextureAnimState AnimState) { return default; }
}
