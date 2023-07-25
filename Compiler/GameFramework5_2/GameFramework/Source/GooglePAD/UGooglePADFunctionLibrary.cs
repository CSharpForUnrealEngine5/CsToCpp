#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GooglePADFunctionLibrary.h")]
public partial class UGooglePADFunctionLibrary : UBlueprintFunctionLibrary {
// GooglePADFunctionLibrary
	public EGooglePADErrorCode RequestInfo(TArray<string> AssetPacks) { return default; }
	public EGooglePADErrorCode RequestDownload(TArray<string> AssetPacks) { return default; }
	public EGooglePADErrorCode CancelDownload(TArray<string> AssetPacks) { return default; }
	public EGooglePADErrorCode GetDownloadState(string Name,int State) { return default; }
	public void ReleaseDownloadState(int State) {}
	public EGooglePADDownloadStatus GetDownloadStatus(int State) { return default; }
	public int GetBytesDownloaded(int State) { return default; }
	public int GetTotalBytesToDownload(int State) { return default; }
	public EGooglePADErrorCode RequestRemoval(string Name) { return default; }
	public EGooglePADErrorCode ShowCellularDataConfirmation() { return default; }
	public EGooglePADErrorCode GetShowCellularDataConfirmationStatus(EGooglePADCellularDataConfirmStatus Status) { return default; }
	public EGooglePADErrorCode GetAssetPackLocation(string Name,int Location) { return default; }
	public void ReleaseAssetPackLocation(int Location) {}
	public EGooglePADStorageMethod GetStorageMethod(int Location) { return default; }
	public string GetAssetsPath(int Location) { return default; }
}
