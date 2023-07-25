#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTextures.h")]
///<summary>Base class for all AR texture types.</summary>
public partial class UARTexture : UTexture {
// ARTexture
	public EARTextureType TextureType;
	public float Timestamp;
	public FGuid ExternalTextureGuid;
	public FVector2D Size;
}
