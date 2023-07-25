#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/ImportanceSamplingLibrary.h")]
public partial class UImportanceSamplingLibrary : UBlueprintFunctionLibrary {
// ImportanceSamplingLibrary
	public float RandomSobolFloat(int Index,int Dimension,float Seed) { return default; }
	public float NextSobolFloat(int Index,int Dimension,float PreviousValue) { return default; }
	public FVector2D RandomSobolCell2D(int Index,int NumCells/*=1*/,FVector2D Cell/*=new FVector2D(0,0)*/,FVector2D Seed/*=new FVector2D(0,0)*/) { return default; }
	public FVector2D NextSobolCell2D(int Index,int NumCells/*=1*/,FVector2D PreviousValue/*=new FVector2D(0,0)*/) { return default; }
	public FVector RandomSobolCell3D(int Index,int NumCells/*=1*/,FVector Cell/*=new FVector(0,0,0)*/,FVector Seed/*=new FVector(0,0,0)*/) { return default; }
	public FVector NextSobolCell3D(int Index,int NumCells/*=1*/,FVector PreviousValue/*=new FVector(0,0,0)*/) { return default; }
	public FImportanceTexture MakeImportanceTexture(UObject Texture,byte WeightingFunc) { return default; }
	public void BreakImportanceTexture(FImportanceTexture ImportanceTexture,UObject Texture,byte WeightingFunc) {}
	public void ImportanceSample(FImportanceTexture Texture,FVector2D Rand,int Samples,float Intensity,FVector2D SamplePosition,FLinearColor SampleColor,float SampleIntensity,float SampleSize) {}
}
