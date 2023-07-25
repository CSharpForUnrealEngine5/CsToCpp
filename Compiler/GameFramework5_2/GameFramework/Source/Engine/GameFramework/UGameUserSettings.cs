#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/GameUserSettings.h")]
///<summary>Stores user settings for a game (for example graphics and sound settings), with the ability to save and load to and from a file.</summary>
public partial class UGameUserSettings : UObject {
// GameUserSettings
	public void ApplySettings(bool bCheckForCommandLineOverrides) {}
	public void ApplyNonResolutionSettings() {}
	public void ApplyResolutionSettings(bool bCheckForCommandLineOverrides) {}
	public FIntPoint GetScreenResolution() { return default; }
	public FIntPoint GetLastConfirmedScreenResolution() { return default; }
	public FIntPoint GetDesktopResolution() { return default; }
	public void SetScreenResolution(FIntPoint Resolution) {}
	public EWindowMode GetFullscreenMode() { return default; }
	public EWindowMode GetLastConfirmedFullscreenMode() { return default; }
	public void SetFullscreenMode(EWindowMode InFullscreenMode) {}
	public EWindowMode GetPreferredFullscreenMode() { return default; }
	public void SetVSyncEnabled(bool bEnable) {}
	public bool IsVSyncEnabled() { return default; }
	public void SetDynamicResolutionEnabled(bool bEnable) {}
	public bool IsDynamicResolutionEnabled() { return default; }
	public bool IsScreenResolutionDirty() { return default; }
	public bool IsFullscreenModeDirty() { return default; }
	public bool IsVSyncDirty() { return default; }
	public bool IsDynamicResolutionDirty() { return default; }
	public void ConfirmVideoMode() {}
	public void RevertVideoMode() {}
	public void SetBenchmarkFallbackValues() {}
	public void SetAudioQualityLevel(int QualityLevel) {}
	public int GetAudioQualityLevel() { return default; }
	public void SetFrameRateLimit(float NewLimit) {}
	public float GetFrameRateLimit() { return default; }
	public void SetOverallScalabilityLevel(int Value) {}
	public int GetOverallScalabilityLevel() { return default; }
	public void GetResolutionScaleInformation(float CurrentScaleNormalized,int CurrentScaleValue,int MinScaleValue,int MaxScaleValue) {}
	public void GetResolutionScaleInformationEx(float CurrentScaleNormalized,float CurrentScaleValue,float MinScaleValue,float MaxScaleValue) {}
	public float GetResolutionScaleNormalized() { return default; }
	public void SetResolutionScaleValue(int NewScaleValue) {}
	public void SetResolutionScaleValueEx(float NewScaleValue) {}
	public void SetResolutionScaleNormalized(float NewScaleNormalized) {}
	public void SetViewDistanceQuality(int Value) {}
	public int GetViewDistanceQuality() { return default; }
	public void SetShadowQuality(int Value) {}
	public int GetShadowQuality() { return default; }
	public void SetGlobalIlluminationQuality(int Value) {}
	public int GetGlobalIlluminationQuality() { return default; }
	public void SetReflectionQuality(int Value) {}
	public int GetReflectionQuality() { return default; }
	public void SetAntiAliasingQuality(int Value) {}
	public int GetAntiAliasingQuality() { return default; }
	public void SetTextureQuality(int Value) {}
	public int GetTextureQuality() { return default; }
	public void SetVisualEffectQuality(int Value) {}
	public int GetVisualEffectQuality() { return default; }
	public void SetPostProcessingQuality(int Value) {}
	public int GetPostProcessingQuality() { return default; }
	public void SetFoliageQuality(int Value) {}
	public int GetFoliageQuality() { return default; }
	public void SetShadingQuality(int Value) {}
	public int GetShadingQuality() { return default; }
	public bool IsDirty() { return default; }
	public void ValidateSettings() {}
	public void LoadSettings(bool bForceReload/*=false*/) {}
	public void SaveSettings() {}
	public void ResetToCurrentSettings() {}
	public void SetToDefaults() {}
	public float GetDefaultResolutionScale() { return default; }
	public float GetRecommendedResolutionScale() { return default; }
	public FIntPoint GetDefaultResolution() { return default; }
	public FIntPoint GetDefaultWindowPosition() { return default; }
	public EWindowMode GetDefaultWindowMode() { return default; }
	public int GetSyncInterval() { return default; }
	public int GetFramePace() { return default; }
	public UObject GetGameUserSettings() { return default; }
	public void RunHardwareBenchmark(int WorkScale/*=10*/,float CPUMultiplier/*=1.0f*/,float GPUMultiplier/*=1.0f*/) {}
	public void ApplyHardwareBenchmarkResults() {}
	public bool SupportsHDRDisplayOutput() { return default; }
	public void EnableHDRDisplayOutput(bool bEnable,int DisplayNits/*=1000*/) {}
	public int GetCurrentHDRDisplayNits() { return default; }
	public bool IsHDREnabled() { return default; }
	public bool bUseVSync;
	public bool bUseDynamicResolution;
	public uint ResolutionSizeX;
	public uint ResolutionSizeY;
	public uint LastUserConfirmedResolutionSizeX;
	public uint LastUserConfirmedResolutionSizeY;
	public int WindowPosX;
	public int WindowPosY;
	public int FullscreenMode;
	public int LastConfirmedFullscreenMode;
	public int PreferredFullscreenMode;
	public uint Version;
	public int AudioQualityLevel;
	public int LastConfirmedAudioQualityLevel;
	public float FrameRateLimit;
	public int DesiredScreenWidth;
	public bool bUseDesiredScreenHeight;
	public int DesiredScreenHeight;
	public int LastUserConfirmedDesiredScreenWidth;
	public int LastUserConfirmedDesiredScreenHeight;
	public float LastRecommendedScreenWidth;
	public float LastRecommendedScreenHeight;
	public float LastCPUBenchmarkResult;
	public float LastGPUBenchmarkResult;
	public TArray<float> LastCPUBenchmarkSteps;
	public TArray<float> LastGPUBenchmarkSteps;
	public float LastGPUBenchmarkMultiplier;
	public bool bUseHDRDisplayOutput;
	public int HDRDisplayOutputNits;
	public FOnGameUserSettingsUINeedsUpdate OnGameUserSettingsUINeedsUpdate;
}
