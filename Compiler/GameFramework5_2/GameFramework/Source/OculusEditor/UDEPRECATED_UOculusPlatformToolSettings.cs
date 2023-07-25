#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusPlatformToolSettings.h")]
public partial class UDEPRECATED_UOculusPlatformToolSettings : UObject {
// UOculusPlatformToolSettings
	public string OculusRiftBuildDirectory;
	public string OculusRiftBuildVersion;
	public string OculusRiftLaunchParams;
	public bool OculusRiftFireWallException;
	public string OculusRift2DLaunchPath;
	public string OculusRift2DLaunchParams;
	public TArray<FRedistPackage> OculusRedistPackages;
	public bool UploadDebugSymbols;
	public bool DebugSymbolsOnly;
	public string BuildID;
	public EOculusPlatformTarget OculusTargetPlatform;
	public TArray<string> OculusApplicationID;
	public TArray<string> OculusApplicationToken;
	public TArray<string> OculusReleaseChannel;
	public TArray<string> OculusReleaseNote;
	public TArray<string> OculusLaunchFilePath;
	public EOculusGamepadEmulation OculusRiftGamepadEmulation;
	public TArray<string> OculusLanguagePacksPath;
	public TArray<string> OculusExpansionFilesPath;
	public TArray<string> OculusSymbolDirPath;
	public TArray<FAssetConfigArray> OculusAssetConfigs;
}
