#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all AR texture types.</summary>
[CppInclude("ARTextures.h")]
public partial class UARTexture : UTexture {
	public static UClass StaticClass() {return default;}
	///<summary>The type of texture this is</summary>
	public EARTextureType TextureType;
	///<summary>The timestamp this texture was captured at</summary>
	public float Timestamp;
	///<summary>The guid of texture that gets registered as an external texture</summary>
	public FGuid ExternalTextureGuid;
	///<summary>The width and height of the texture</summary>
	public FVector2D Size;
}
