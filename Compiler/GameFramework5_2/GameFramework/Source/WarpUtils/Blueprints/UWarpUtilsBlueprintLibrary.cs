#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/WarpUtilsBlueprintLibrary.h")]
public partial class UWarpUtilsBlueprintLibrary : UBlueprintFunctionLibrary {
// WarpUtilsBlueprintLibrary
	public bool SavePFM(string File,int TexWidth,int TexHeight,TArray<FVector> Vertices) { return default; }
	public bool SavePFMEx(string File,int TexWidth,int TexHeight,TArray<FVector> Vertices,TArray<bool> TilesValidityFlags) { return default; }
	public bool GeneratePFM(string File,FVector StartLocation,FRotator StartRotation,UObject PFMOrigin,int TilesHorizontal,int TilesVertical,float ColumnAngle,float TileSizeHorizontal,float TileSizeVertical,int TilePixelsHorizontal,int TilePixelsVertical,bool AddMargin) { return default; }
	public bool GeneratePFMEx(string File,FVector StartLocation,FRotator StartRotation,UObject PFMOrigin,int TilesHorizontal,int TilesVertical,float ColumnAngle,float TileSizeHorizontal,float TileSizeVertical,int TilePixelsHorizontal,int TilePixelsVertical,bool AddMargin,TArray<bool> TilesValidityFlags) { return default; }
}
