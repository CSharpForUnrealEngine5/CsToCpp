#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SparseVolumeTexture/SparseVolumeTextureViewerComponent.h")]
///<summary>A component used to inspect sparse volume textures.</summary>
public partial class USparseVolumeTextureViewerComponent : UPrimitiveComponent {
// SparseVolumeTextureViewerComponent
	public USparseVolumeTexture SparseVolumeTexturePreview;
	public bool bAnimate;
	public float AnimationFrame;
	public float FrameRate;
	public float AnimationTime;
	public int ComponentToVisualize;
}
