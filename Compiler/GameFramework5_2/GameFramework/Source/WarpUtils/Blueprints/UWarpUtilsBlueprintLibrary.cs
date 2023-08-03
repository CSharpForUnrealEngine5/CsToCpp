#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/WarpUtilsBlueprintLibrary.h")]
public partial class UWarpUtilsBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Save data to a PFM file</summary>
	public static bool SavePFM(string File,int TexWidth,int TexHeight,TArray<FVector> Vertices) { return default; }
	///<summary>Save data to a PFM file. Since the float NaN value is not available in blueprints, we provide a flags array (false == NaN)</summary>
	public static bool SavePFMEx(string File,int TexWidth,int TexHeight,TArray<FVector> Vertices,TArray<bool> TilesValidityFlags) { return default; }
	///<summary>Generate and save data to a PFM file</summary>
	public static bool GeneratePFM(string File,FVector StartLocation,FRotator StartRotation,AActor PFMOrigin,int TilesHorizontal,int TilesVertical,float ColumnAngle,float TileSizeHorizontal,float TileSizeVertical,int TilePixelsHorizontal,int TilePixelsVertical,bool AddMargin) { return default; }
	///<summary>Generate and save data to a PFM file. Additionally, we have an array of tiles validiy flags (false == all pixels of a tile are NaN)</summary>
	public static bool GeneratePFMEx(string File,FVector StartLocation,FRotator StartRotation,AActor PFMOrigin,int TilesHorizontal,int TilesVertical,float ColumnAngle,float TileSizeHorizontal,float TileSizeVertical,int TilePixelsHorizontal,int TilePixelsVertical,bool AddMargin,TArray<bool> TilesValidityFlags) { return default; }
}
