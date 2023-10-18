namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds texture information with UV coordinates as well.</summary>
[CppInclude("Engine/Canvas.h")]
public partial struct FCanvasIcon {
	public UTexture Texture;
	public float U;
	public float V;
	public float UL;
	public float VL;
}
