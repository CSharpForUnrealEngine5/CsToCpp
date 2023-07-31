#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component used to inspect sparse volume textures.</summary>
[CppInclude("SparseVolumeTexture/SparseVolumeTextureViewerComponent.h")]
public partial class USparseVolumeTextureViewerComponent : UPrimitiveComponent {
	///<summary>SparseVolumeTexturePreview</summary>
	public USparseVolumeTexture SparseVolumeTexturePreview;
	///<summary>bAnimate</summary>
	public bool bAnimate;
	///<summary>AnimationFrame</summary>
	public float AnimationFrame;
	///<summary>FrameRate</summary>
	public float FrameRate;
	///<summary>AnimationTime</summary>
	public float AnimationTime;
	///<summary>ComponentToVisualize</summary>
	public int ComponentToVisualize;
}
