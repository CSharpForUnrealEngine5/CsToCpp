namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GooglePADFunctionLibrary.h")]
///<summary>The status associated with Asset Pack download operations.</summary>
public enum EGooglePADDownloadStatus {
	AssetPack_UNKNOWN=0,
	AssetPack_DOWNLOAD_PENDING=1,
	AssetPack_DOWNLOADING=2,
	AssetPack_TRANSFERRING=3,
	AssetPack_DOWNLOAD_COMPLETED=4,
	AssetPack_DOWNLOAD_FAILED=5,
	AssetPack_DOWNLOAD_CANCELED=6,
	AssetPack_WAITING_FOR_WIFI=7,
	AssetPack_NOT_INSTALLED=8,
	AssetPack_INFO_PENDING=9,
	AssetPack_INFO_FAILED=10,
	AssetPack_REMOVAL_PENDING=11,
	AssetPack_REMOVAL_FAILED=12,
}
