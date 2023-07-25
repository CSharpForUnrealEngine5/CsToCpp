#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTextures.h")]
///<summary>Base class for all AR textures that represent the environment for lighting and reflection</summary>
public partial class UAREnvironmentCaptureProbeTexture : UTextureCube {
// AREnvironmentCaptureProbeTexture
	public EARTextureType TextureType;
	public float Timestamp;
	public FGuid ExternalTextureGuid;
	public FVector2D Size;
}
