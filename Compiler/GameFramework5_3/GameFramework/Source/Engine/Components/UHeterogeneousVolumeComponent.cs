namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that represents a heterogeneous volume.</summary>
[CppInclude("Components/HeterogeneousVolumeComponent.h")]
public partial class UHeterogeneousVolumeComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>VolumeResolution</summary>
	public FIntVector VolumeResolution;
	///<summary>Frame</summary>
	public float Frame;
	///<summary>FrameRate</summary>
	public float FrameRate;
	///<summary>StartFrame</summary>
	public float StartFrame;
	///<summary>EndFrame</summary>
	public float EndFrame;
	///<summary>bPlaying</summary>
	public bool bPlaying;
	///<summary>bLooping</summary>
	public bool bLooping;
	///<summary>MipLevel</summary>
	public uint MipLevel;
	///<summary>bIssueBlockingRequests</summary>
	public bool bIssueBlockingRequests;
	///<summary>StepFactor</summary>
	public float StepFactor;
	///<summary>ShadowStepFactor</summary>
	public float ShadowStepFactor;
	///<summary>ShadowBiasFactor</summary>
	public float ShadowBiasFactor;
	///<summary>LightingDownsampleFactor</summary>
	public float LightingDownsampleFactor;
	///<summary>MaterialInstanceDynamic</summary>
	public UMaterialInstanceDynamic MaterialInstanceDynamic;
	///<summary>SetFrame</summary>
	public void SetFrame(float NewValue) {}
	///<summary>SetFrameRate</summary>
	public void SetFrameRate(float NewValue) {}
	///<summary>SetStartFrame</summary>
	public void SetStartFrame(float NewValue) {}
	///<summary>SetEndFrame</summary>
	public void SetEndFrame(float NewValue) {}
	///<summary>SetPlaying</summary>
	public void SetPlaying(bool NewValue) {}
	///<summary>SetLooping</summary>
	public void SetLooping(bool NewValue) {}
	///<summary>Play</summary>
	public void Play() {}
}
