#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Inherits from UBlueprintFunctionLibrary to allow exposure to Blueprint Library in the same class.</summary>
[CppInclude("IO/LidarPointCloudFileIO_ASCII.h")]
public partial class ULidarPointCloudFileIO_ASCII : UBlueprintFunctionLibrary {
	///<summary>CreatePointCloudFromFile</summary>
	public static void CreatePointCloudFromFile(UObject WorldContextObject,string Filename,bool bUseAsync,FVector2D RGBRange,FLidarPointCloudImportSettings_ASCII_Columns Columns,FLatentActionInfo LatentInfo,ELidarPointCloudAsyncMode AsyncMode,float Progress,ULidarPointCloud PointCloud) {}
}
