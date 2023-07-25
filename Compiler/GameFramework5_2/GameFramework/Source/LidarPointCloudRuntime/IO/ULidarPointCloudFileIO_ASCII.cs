#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IO/LidarPointCloudFileIO_ASCII.h")]
///<summary>Inherits from UBlueprintFunctionLibrary to allow exposure to Blueprint Library in the same class.</summary>
public partial class ULidarPointCloudFileIO_ASCII : UBlueprintFunctionLibrary {
// LidarPointCloudFileIO_ASCII
	public void CreatePointCloudFromFile(UObject WorldContextObject,string Filename,bool bUseAsync,FVector2D RGBRange,FLidarPointCloudImportSettings_ASCII_Columns Columns,FLatentActionInfo LatentInfo,ELidarPointCloudAsyncMode AsyncMode,float Progress,UObject PointCloud) {}
}
