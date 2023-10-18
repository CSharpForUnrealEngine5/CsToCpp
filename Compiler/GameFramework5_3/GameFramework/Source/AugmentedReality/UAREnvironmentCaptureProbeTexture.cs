namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all AR textures that represent the environment for lighting and reflection</summary>
[CppInclude("ARTextures.h")]
public partial class UAREnvironmentCaptureProbeTexture : UTextureCube {
	public static UClass StaticClass() {return default;}
	///<summary>The type of texture this is</summary>
	public EARTextureType TextureType;
	///<summary>The timestamp this texture was captured at</summary>
	public float Timestamp;
	///<summary>The guid of texture that gets registered as an external texture</summary>
	public FGuid ExternalTextureGuid;
	///<summary>The width and height of the texture</summary>
	public FVector2f Size;
}
