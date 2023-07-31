#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Texture processed for importance sampling</summary>
[CppInclude("Kismet/ImportanceSamplingLibrary.h")]
public partial struct FImportanceTexture {
	public FIntPoint Size;
	public int NumMips;
	public TArray<float> MarginalCDF;
	public TArray<float> ConditionalCDF;
	public TArray<FColor> TextureData;
	public TWeakObjectPtr<UTexture2D> Texture;
	public EImportanceWeight Weighting;
}
