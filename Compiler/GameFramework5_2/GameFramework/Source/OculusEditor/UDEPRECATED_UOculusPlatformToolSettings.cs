#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusPlatformToolSettings.h")]
public partial class UDEPRECATED_UOculusPlatformToolSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OculusRiftBuildDirectory</summary>
	public string OculusRiftBuildDirectory;
	///<summary>OculusRiftBuildVersion</summary>
	public string OculusRiftBuildVersion;
	///<summary>OculusRiftLaunchParams</summary>
	public string OculusRiftLaunchParams;
	///<summary>OculusRiftFireWallException</summary>
	public bool OculusRiftFireWallException;
	///<summary>OculusRift2DLaunchPath</summary>
	public string OculusRift2DLaunchPath;
	///<summary>OculusRift2DLaunchParams</summary>
	public string OculusRift2DLaunchParams;
	///<summary>OculusRedistPackages</summary>
	public TArray<FRedistPackage> OculusRedistPackages;
	///<summary>UploadDebugSymbols</summary>
	public bool UploadDebugSymbols;
	///<summary>DebugSymbolsOnly</summary>
	public bool DebugSymbolsOnly;
	///<summary>BuildID</summary>
	public string BuildID;
	///<summary>OculusTargetPlatform</summary>
	public EOculusPlatformTarget OculusTargetPlatform;
	///<summary>OculusApplicationID</summary>
	public TArray<string> OculusApplicationID;
	///<summary>OculusApplicationToken</summary>
	public TArray<string> OculusApplicationToken;
	///<summary>OculusReleaseChannel</summary>
	public TArray<string> OculusReleaseChannel;
	///<summary>OculusReleaseNote</summary>
	public TArray<string> OculusReleaseNote;
	///<summary>OculusLaunchFilePath</summary>
	public TArray<string> OculusLaunchFilePath;
	///<summary>OculusRiftGamepadEmulation</summary>
	public EOculusGamepadEmulation OculusRiftGamepadEmulation;
	///<summary>OculusLanguagePacksPath</summary>
	public TArray<string> OculusLanguagePacksPath;
	///<summary>OculusExpansionFilesPath</summary>
	public TArray<string> OculusExpansionFilesPath;
	///<summary>OculusSymbolDirPath</summary>
	public TArray<string> OculusSymbolDirPath;
	///<summary>OculusAssetConfigs</summary>
	public TArray<FAssetConfigArray> OculusAssetConfigs;
}
