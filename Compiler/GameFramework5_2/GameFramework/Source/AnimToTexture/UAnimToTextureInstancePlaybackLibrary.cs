#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimToTextureInstancePlaybackHelpers.h")]
public partial class UAnimToTextureInstancePlaybackLibrary : UBlueprintFunctionLibrary {
// AnimToTextureInstancePlaybackLibrary
	public void SetupInstancedMeshComponent(UObject InstancedMeshComponent,FAnimToTextureInstanceData InstanceData,int NumInstances) {}
	public void BatchUpdateInstancedMeshComponent(UObject InstancedMeshComponent,FAnimToTextureInstanceData InstanceData) {}
	public void AllocateInstanceData(FAnimToTextureInstanceData InstanceData,int Count) {}
	public bool UpdateInstanceData(FAnimToTextureInstanceData InstanceData,int InstanceIndex,FAnimToTextureInstancePlaybackData PlaybackData,FTransform Transform) { return default; }
	public bool GetInstancePlaybackData(FAnimToTextureInstanceData InstanceData,int InstanceIndex,FAnimToTextureInstancePlaybackData InstancePlaybackData) { return default; }
	public bool GetInstanceTransform(FAnimToTextureInstanceData InstanceData,int InstanceIndex,FTransform InstanceTransform) { return default; }
	public bool AnimStateFromDataAsset(UObject DataAsset,int StateIndex,FAnimToTextureAnimState AnimState) { return default; }
}
