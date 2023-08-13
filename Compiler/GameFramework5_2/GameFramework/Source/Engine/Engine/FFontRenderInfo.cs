namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information used in font rendering</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FFontRenderInfo {
	public bool bClipText;
	public bool bEnableShadow;
	public FDepthFieldGlowInfo GlowInfo;
}
