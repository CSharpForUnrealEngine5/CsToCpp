#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GooglePADFunctionLibrary.h")]
public partial class UGooglePADFunctionLibrary : UBlueprintFunctionLibrary {
// GooglePADFunctionLibrary
	public static EGooglePADErrorCode RequestInfo(TArray<string> AssetPacks) { return default; }
	public static EGooglePADErrorCode RequestDownload(TArray<string> AssetPacks) { return default; }
	public static EGooglePADErrorCode CancelDownload(TArray<string> AssetPacks) { return default; }
	public static EGooglePADErrorCode GetDownloadState(string Name,int State) { return default; }
	public static void ReleaseDownloadState(int State) {}
	public static EGooglePADDownloadStatus GetDownloadStatus(int State) { return default; }
	public static int GetBytesDownloaded(int State) { return default; }
	public static int GetTotalBytesToDownload(int State) { return default; }
	public static EGooglePADErrorCode RequestRemoval(string Name) { return default; }
	public static EGooglePADErrorCode ShowCellularDataConfirmation() { return default; }
	public static EGooglePADErrorCode GetShowCellularDataConfirmationStatus(EGooglePADCellularDataConfirmStatus Status) { return default; }
	public static EGooglePADErrorCode GetAssetPackLocation(string Name,int Location) { return default; }
	public static void ReleaseAssetPackLocation(int Location) {}
	public static EGooglePADStorageMethod GetStorageMethod(int Location) { return default; }
	public static string GetAssetsPath(int Location) { return default; }
}
