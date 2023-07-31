#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureDefines.h")]
///<summary>Certain settings can be changed to facilitate how fast a texture build takes. This</summary>
public enum ETextureEncodeSpeed {
	Final=0,
	FinalIfAvailable=1,
	Fast=2,
}
