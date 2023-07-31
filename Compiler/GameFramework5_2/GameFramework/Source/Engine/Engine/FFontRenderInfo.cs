#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information used in font rendering</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FFontRenderInfo {
	public bool bClipText;
	public bool bEnableShadow;
	public FDepthFieldGlowInfo GlowInfo;
}
