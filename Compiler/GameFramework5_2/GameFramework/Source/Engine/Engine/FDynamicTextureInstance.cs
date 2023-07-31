#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Serialized ULevel information about dynamic texture instances</summary>
[CppInclude("Engine/Level.h")]
public partial struct FDynamicTextureInstance {
	public UTexture2D Texture;
	public bool bAttached;
	public float OriginalRadius;
}
