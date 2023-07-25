#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/ImportanceSamplingLibrary.h")]
///<summary>Texture processed for importance sampling</summary>
public partial struct FImportanceTexture {
// ImportanceTexture
	public FIntPoint Size;
	public int NumMips;
	public TArray<float> MarginalCDF;
	public TArray<float> ConditionalCDF;
	public TArray<FColor> TextureData;
	public TWeakObjectPtr<UTexture2D> Texture;
	public byte Weighting;
}
