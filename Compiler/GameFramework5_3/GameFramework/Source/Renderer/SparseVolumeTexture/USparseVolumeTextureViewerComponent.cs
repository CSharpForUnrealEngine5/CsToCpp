namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component used to inspect sparse volume textures.</summary>
[CppInclude("SparseVolumeTexture/SparseVolumeTextureViewerComponent.h")]
public partial class USparseVolumeTextureViewerComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SparseVolumeTexturePreview</summary>
	public USparseVolumeTexture SparseVolumeTexturePreview;
	///<summary>bAnimate</summary>
	public bool bAnimate;
	///<summary>bReversePlayback</summary>
	public bool bReversePlayback;
	///<summary>bBlockingStreamingRequests</summary>
	public bool bBlockingStreamingRequests;
	///<summary>AnimationFrame</summary>
	public float AnimationFrame;
	///<summary>FrameRate</summary>
	public float FrameRate;
	///<summary>AnimationTime</summary>
	public float AnimationTime;
	///<summary>PreviewAttribute</summary>
	public ESparseVolumeTexturePreviewAttribute PreviewAttribute;
	///<summary>MipLevel</summary>
	public int MipLevel;
	///<summary>Extinction</summary>
	public float Extinction;
}
