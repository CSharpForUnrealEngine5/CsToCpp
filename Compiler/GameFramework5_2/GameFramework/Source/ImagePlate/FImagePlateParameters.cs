#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImagePlateComponent.h")]
public partial struct FImagePlateParameters {
	public UMaterialInterface Material;
	public string TextureParameterName;
	public bool bFillScreen;
	public FVector2D FillScreenAmount;
	public FVector2D FixedSize;
	public UTexture RenderTexture;
	public UMaterialInstanceDynamic DynamicMaterial;
}
