namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimToTextureInstancePlaybackHelpers.h")]
public partial class UAnimToTextureInstancePlaybackLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Adds Instances and allocates the necessary CustomData.</summary>
	public static bool SetupInstancedMeshComponent(UInstancedStaticMeshComponent InstancedMeshComponent,int NumInstances,bool bAutoPlay) { return default; }
	///<summary>Updates all instances with the given Transforms and AutoPlayData</summary>
	public static bool BatchUpdateInstancesAutoPlayData(UInstancedStaticMeshComponent InstancedMeshComponent,TArray<FAnimToTextureAutoPlayData> AutoPlayData,TArray<FMatrix> Transforms,bool bMarkRenderStateDirty/*=true*/) { return default; }
	///<summary>Updates all instances with the given Transforms and FrameData</summary>
	public static bool BatchUpdateInstancesFrameData(UInstancedStaticMeshComponent InstancedMeshComponent,TArray<FAnimToTextureFrameData> FrameData,TArray<FMatrix> Transforms,bool bMarkRenderStateDirty/*=true*/) { return default; }
	///<summary>Updates a single instance with given AutoPlayData</summary>
	public static bool UpdateInstanceAutoPlayData(UInstancedStaticMeshComponent InstancedMeshComponent,int InstanceIndex,FAnimToTextureAutoPlayData AutoPlayData,bool bMarkRenderStateDirty/*=true*/) { return default; }
	///<summary>* Updates a single instance with given FrameData</summary>
	public static bool UpdateInstanceFrameData(UInstancedStaticMeshComponent InstancedMeshComponent,int InstanceIndex,FAnimToTextureFrameData FrameData,bool bMarkRenderStateDirty/*=true*/) { return default; }
	///<summary>Returns an AutoPlayData with the Start and End Frame for the given AnimationIndex.</summary>
	public static bool GetAutoPlayDataFromDataAsset(UAnimToTextureDataAsset DataAsset,int AnimationIndex,FAnimToTextureAutoPlayData AutoPlayData,float TimeOffset/*=0.0f*/,float PlayRate/*=1.0f*/) { return default; }
	///<summary>GetFrame</summary>
	public static float GetFrame(float Time,float StartFrame,float EndFrame,float TimeOffset/*=0.0f*/,float PlayRate/*=1.0f*/,float SampleRate/*=30.0f*/) { return default; }
	///<summary>GetFrameDataFromDataAsset</summary>
	public static bool GetFrameDataFromDataAsset(UAnimToTextureDataAsset DataAsset,int AnimationIndex,float Time,FAnimToTextureFrameData AutoPlayData,float TimeOffset/*=0.0f*/,float PlayRate/*=1.0f*/) { return default; }
}
