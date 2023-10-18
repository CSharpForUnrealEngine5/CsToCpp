namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureDefines.h")]
public enum ETextureClass {
	Invalid=0,
	TwoD=1,
	Cube=2,
	Array=3,
	CubeArray=4,
	Volume=5,
	TwoDDynamic=6,
	RenderTarget=7,
	Other2DNoSource=8,
	OtherUnknown=9,
}
