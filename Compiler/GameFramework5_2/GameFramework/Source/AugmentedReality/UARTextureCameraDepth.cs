#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTextures.h")]
///<summary>Base class for all AR textures that represent the camera depth data</summary>
public partial class UARTextureCameraDepth : UARTexture {
// ARTextureCameraDepth
	public EARDepthQuality DepthQuality;
	public EARDepthAccuracy DepthAccuracy;
	public bool bIsTemporallySmoothed;
}
