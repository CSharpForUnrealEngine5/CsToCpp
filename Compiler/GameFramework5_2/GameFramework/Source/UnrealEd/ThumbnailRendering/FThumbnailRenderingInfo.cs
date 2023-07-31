#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds the settings for a class that needs a thumbnail renderer. Each entry</summary>
[CppInclude("ThumbnailRendering/ThumbnailManager.h")]
public partial struct FThumbnailRenderingInfo {
	public string ClassNeedingThumbnailName;
	public UClass ClassNeedingThumbnail;
	public string RendererClassName;
	public UThumbnailRenderer Renderer;
}
