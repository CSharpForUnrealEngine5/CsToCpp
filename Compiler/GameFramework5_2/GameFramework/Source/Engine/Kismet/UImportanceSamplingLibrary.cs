#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/ImportanceSamplingLibrary.h")]
public partial class UImportanceSamplingLibrary : UBlueprintFunctionLibrary {
// ImportanceSamplingLibrary
	public static float RandomSobolFloat(int Index,int Dimension,float Seed) { return default; }
	public static float NextSobolFloat(int Index,int Dimension,float PreviousValue) { return default; }
	public static FVector2D RandomSobolCell2D(int Index,int NumCells/*=1*/,FVector2D Cell/*=new FVector2D(0,0)*/,FVector2D Seed/*=new FVector2D(0,0)*/) { return default; }
	public static FVector2D NextSobolCell2D(int Index,int NumCells/*=1*/,FVector2D PreviousValue/*=new FVector2D(0,0)*/) { return default; }
	public static FVector RandomSobolCell3D(int Index,int NumCells/*=1*/,FVector Cell/*=new FVector(0,0,0)*/,FVector Seed/*=new FVector(0,0,0)*/) { return default; }
	public static FVector NextSobolCell3D(int Index,int NumCells/*=1*/,FVector PreviousValue/*=new FVector(0,0,0)*/) { return default; }
	public static FImportanceTexture MakeImportanceTexture(UTexture2D Texture,EImportanceWeight WeightingFunc) { return default; }
	public static void BreakImportanceTexture(FImportanceTexture ImportanceTexture,UTexture2D Texture,EImportanceWeight WeightingFunc) {}
	public static void ImportanceSample(FImportanceTexture Texture,FVector2D Rand,int Samples,float Intensity,FVector2D SamplePosition,FLinearColor SampleColor,float SampleIntensity,float SampleSize) {}
}
