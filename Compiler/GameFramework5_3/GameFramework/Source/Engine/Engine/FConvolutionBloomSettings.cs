namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Scene.h")]
public partial struct FConvolutionBloomSettings {
	public UTexture2D Texture;
	public float ScatterDispersion;
	public float Size;
	public FVector2D CenterUV;
	public float PreFilterMin;
	public float PreFilterMax;
	public float PreFilterMult;
	public float BufferScale;
}
