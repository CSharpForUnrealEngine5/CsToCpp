namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A geometry map for the stage, which contains a generated texture of the stage geometry&#39;s depth and normal vectors</summary>
[CppInclude("Components/DisplayClusterStageGeometryComponent.h")]
public partial struct FDisplayClusterStageGeometryMap {
	public UTextureRenderTarget2D RenderTarget;
	public UTexture2D Texture;
}
