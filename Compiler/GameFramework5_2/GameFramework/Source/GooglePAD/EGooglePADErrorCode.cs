#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GooglePADFunctionLibrary.h")]
///<summary>An error code associated with Asset Pack operations.</summary>
public enum EGooglePADErrorCode {
	AssetPack_NO_ERROR=0,
	AssetPack_APP_UNAVAILABLE=1,
	AssetPack_UNAVAILABLE=2,
	AssetPack_INVALID_REQUEST=3,
	AssetPack_DOWNLOAD_NOT_FOUND=4,
	AssetPack_API_NOT_AVAILABLE=5,
	AssetPack_NETWORK_ERROR=6,
	AssetPack_ACCESS_DENIED=7,
	AssetPack_INSUFFICIENT_STORAGE=8,
	AssetPack_PLAY_STORE_NOT_FOUND=9,
	AssetPack_NETWORK_UNRESTRICTED=10,
	AssetPack_INTERNAL_ERROR=11,
	AssetPack_INITIALIZATION_NEEDED=12,
	AssetPack_INITIALIZATION_FAILED=13,
}
