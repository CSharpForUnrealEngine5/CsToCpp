#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GooglePADFunctionLibrary.h")]
public partial class UGooglePADFunctionLibrary : UBlueprintFunctionLibrary {
	///<summary>Request information about a set of asset packs</summary>
	public static EGooglePADErrorCode RequestInfo(TArray<string> AssetPacks) { return default; }
	///<summary>Request download of a set of asset packs</summary>
	public static EGooglePADErrorCode RequestDownload(TArray<string> AssetPacks) { return default; }
	///<summary>Cancel download of a set of asset packs</summary>
	public static EGooglePADErrorCode CancelDownload(TArray<string> AssetPacks) { return default; }
	///<summary>Get download state handle of an asset pack (release when done)</summary>
	public static EGooglePADErrorCode GetDownloadState(string Name,int State) { return default; }
	///<summary>Release download state resources</summary>
	public static void ReleaseDownloadState(int State) {}
	///<summary>Get download status from a download state</summary>
	public static EGooglePADDownloadStatus GetDownloadStatus(int State) { return default; }
	///<summary>Get the number of bytes downloaded from a download state</summary>
	public static int GetBytesDownloaded(int State) { return default; }
	///<summary>Get the total number of bytes to download from a download state</summary>
	public static int GetTotalBytesToDownload(int State) { return default; }
	///<summary>Request removal of an asset pack</summary>
	public static EGooglePADErrorCode RequestRemoval(string Name) { return default; }
	///<summary>Show confirmation dialog requesting data download over cellular network</summary>
	public static EGooglePADErrorCode ShowCellularDataConfirmation() { return default; }
	///<summary>Get status of cellular confirmation dialog</summary>
	public static EGooglePADErrorCode GetShowCellularDataConfirmationStatus(EGooglePADCellularDataConfirmStatus Status) { return default; }
	///<summary>Get location handle of requested asset pack (release when done)</summary>
	public static EGooglePADErrorCode GetAssetPackLocation(string Name,int Location) { return default; }
	///<summary>Release location resources</summary>
	public static void ReleaseAssetPackLocation(int Location) {}
	///<summary>Get storage method from location</summary>
	public static EGooglePADStorageMethod GetStorageMethod(int Location) { return default; }
	///<summary>Get asset path from from location</summary>
	public static string GetAssetsPath(int Location) { return default; }
}
