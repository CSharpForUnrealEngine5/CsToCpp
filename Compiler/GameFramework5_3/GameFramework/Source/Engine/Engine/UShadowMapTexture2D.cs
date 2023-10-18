namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ShadowMapTexture2D.h")]
public partial class UShadowMapTexture2D : UTexture2D {
	public static UClass StaticClass() {return default;}
	///<summary>Bit-field with shadowmap flags.</summary>
	public EShadowMapFlags ShadowmapFlags;
}
