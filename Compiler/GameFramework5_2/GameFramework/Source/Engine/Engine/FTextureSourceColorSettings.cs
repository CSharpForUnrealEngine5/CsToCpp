#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Texture.h")]
public partial struct FTextureSourceColorSettings {
	public ETextureSourceEncoding EncodingOverride;
	public ETextureColorSpace ColorSpace;
	public FVector2D RedChromaticityCoordinate;
	public FVector2D GreenChromaticityCoordinate;
	public FVector2D BlueChromaticityCoordinate;
	public FVector2D WhiteChromaticityCoordinate;
	public ETextureChromaticAdaptationMethod ChromaticAdaptationMethod;
}
