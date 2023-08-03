#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/ImportanceSamplingLibrary.h")]
public partial class UImportanceSamplingLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>@param Index - Which sequential point</summary>
	public static float RandomSobolFloat(int Index,int Dimension,float Seed) { return default; }
	///<summary>@param Index - Which sequential point</summary>
	public static float NextSobolFloat(int Index,int Dimension,float PreviousValue) { return default; }
	///<summary>@param Index - Which sequential point in the cell (starting at 0)</summary>
	public static FVector2D RandomSobolCell2D(int Index,int NumCells/*=1*/,FVector2D Cell/*=new FVector2D(0,0)*/,FVector2D Seed/*=new FVector2D(0,0)*/) { return default; }
	///<summary>@param Index - Which sequential point</summary>
	public static FVector2D NextSobolCell2D(int Index,int NumCells/*=1*/,FVector2D PreviousValue/*=new FVector2D(0,0)*/) { return default; }
	///<summary>@param Index - Which sequential point in the cell (starting at 0)</summary>
	public static FVector RandomSobolCell3D(int Index,int NumCells/*=1*/,FVector Cell/*=new FVector(0,0,0)*/,FVector Seed/*=new FVector(0,0,0)*/) { return default; }
	///<summary>@param Index - Which sequential point</summary>
	public static FVector NextSobolCell3D(int Index,int NumCells/*=1*/,FVector PreviousValue/*=new FVector(0,0,0)*/) { return default; }
	///<summary>Create an FImportanceTexture object for texture-driven importance sampling from a 2D RGBA8 texture</summary>
	public static FImportanceTexture MakeImportanceTexture(UTexture2D Texture,EImportanceWeight WeightingFunc) { return default; }
	///<summary>Get texture used to create an ImportanceTexture object</summary>
	public static void BreakImportanceTexture(FImportanceTexture ImportanceTexture,UTexture2D Texture,EImportanceWeight WeightingFunc) {}
	///<summary>Distribute sample points proportional to Texture2D luminance.</summary>
	public static void ImportanceSample(FImportanceTexture Texture,FVector2D Rand,int Samples,float Intensity,FVector2D SamplePosition,FLinearColor SampleColor,float SampleIntensity,float SampleSize) {}
}
