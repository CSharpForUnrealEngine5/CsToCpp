namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImagePlateComponent.h")]
public partial struct FImagePlateParameters {
	public UMaterialInterface Material;
	public FName TextureParameterName;
	public bool bFillScreen;
	public FVector2D FillScreenAmount;
	public FVector2D FixedSize;
	public UTexture RenderTexture;
	public UMaterialInstanceDynamic DynamicMaterial;
}
