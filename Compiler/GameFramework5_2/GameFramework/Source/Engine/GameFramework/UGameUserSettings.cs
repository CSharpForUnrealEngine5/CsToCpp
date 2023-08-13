namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores user settings for a game (for example graphics and sound settings), with the ability to save and load to and from a file.</summary>
[CppInclude("GameFramework/GameUserSettings.h")]
public partial class UGameUserSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Applies all current user settings to the game and saves to permanent storage (e.g. file), optionally checking for command line overrides.</summary>
	public virtual void ApplySettings(bool bCheckForCommandLineOverrides) {}
	///<summary>ApplyNonResolutionSettings</summary>
	public virtual void ApplyNonResolutionSettings() {}
	///<summary>ApplyResolutionSettings</summary>
	public void ApplyResolutionSettings(bool bCheckForCommandLineOverrides) {}
	///<summary>Returns the user setting for game screen resolution, in pixels.</summary>
	public FIntPoint GetScreenResolution() { return default; }
	///<summary>Returns the last confirmed user setting for game screen resolution, in pixels.</summary>
	public FIntPoint GetLastConfirmedScreenResolution() { return default; }
	///<summary>Returns user&#39;s desktop resolution, in pixels.</summary>
	public FIntPoint GetDesktopResolution() { return default; }
	///<summary>Sets the user setting for game screen resolution, in pixels.</summary>
	public void SetScreenResolution(FIntPoint Resolution) {}
	///<summary>Returns the user setting for game window fullscreen mode.</summary>
	public EWindowMode GetFullscreenMode() { return default; }
	///<summary>Returns the last confirmed user setting for game window fullscreen mode.</summary>
	public EWindowMode GetLastConfirmedFullscreenMode() { return default; }
	///<summary>Sets the user setting for the game window fullscreen mode. See UGameUserSettings::FullscreenMode.</summary>
	public void SetFullscreenMode(EWindowMode InFullscreenMode) {}
	///<summary>Returns the user setting for game window fullscreen mode.</summary>
	public EWindowMode GetPreferredFullscreenMode() { return default; }
	///<summary>Sets the user setting for vsync. See UGameUserSettings::bUseVSync.</summary>
	public void SetVSyncEnabled(bool bEnable) {}
	///<summary>Returns the user setting for vsync.</summary>
	public bool IsVSyncEnabled() { return default; }
	///<summary>Sets the user setting for dynamic resolution. See UGameUserSettings::bUseDynamicResolution.</summary>
	public void SetDynamicResolutionEnabled(bool bEnable) {}
	///<summary>Returns the user setting for dynamic resolution.</summary>
	public virtual bool IsDynamicResolutionEnabled() { return default; }
	///<summary>Checks if the Screen Resolution user setting is different from current</summary>
	public bool IsScreenResolutionDirty() { return default; }
	///<summary>Checks if the FullscreenMode user setting is different from current</summary>
	public bool IsFullscreenModeDirty() { return default; }
	///<summary>Checks if the vsync user setting is different from current system setting</summary>
	public bool IsVSyncDirty() { return default; }
	///<summary>Checks if the dynamic resolution user setting is different from current system setting</summary>
	public bool IsDynamicResolutionDirty() { return default; }
	///<summary>Mark current video mode settings (fullscreenmode/resolution) as being confirmed by the user</summary>
	public virtual void ConfirmVideoMode() {}
	///<summary>Revert video mode (fullscreenmode/resolution) back to the last user confirmed values</summary>
	public void RevertVideoMode() {}
	///<summary>Set scalability settings to sensible fallback values, for use when the benchmark fails or potentially causes a crash</summary>
	public void SetBenchmarkFallbackValues() {}
	///<summary>Sets the user&#39;s audio quality level setting</summary>
	public void SetAudioQualityLevel(int QualityLevel) {}
	///<summary>Returns the user&#39;s audio quality level setting</summary>
	public int GetAudioQualityLevel() { return default; }
	///<summary>Sets the user&#39;s frame rate limit (0 will disable frame rate limiting)</summary>
	public void SetFrameRateLimit(float NewLimit) {}
	///<summary>Gets the user&#39;s frame rate limit (0 indiciates the frame rate limit is disabled)</summary>
	public float GetFrameRateLimit() { return default; }
	///<summary>Changes all scalability settings at once based on a single overall quality level</summary>
	public virtual void SetOverallScalabilityLevel(int Value) {}
	///<summary>Returns the overall scalability level (can return -1 if the settings are custom)</summary>
	public virtual int GetOverallScalabilityLevel() { return default; }
	///<summary>GetResolutionScaleInformation</summary>
	public void GetResolutionScaleInformation(float CurrentScaleNormalized,int CurrentScaleValue,int MinScaleValue,int MaxScaleValue) {}
	///<summary>Returns the current resolution scale and the range</summary>
	public void GetResolutionScaleInformationEx(float CurrentScaleNormalized,float CurrentScaleValue,float MinScaleValue,float MaxScaleValue) {}
	///<summary>Gets the current resolution scale as a normalized 0..1 value between MinScaleValue and MaxScaleValue</summary>
	public float GetResolutionScaleNormalized() { return default; }
	///<summary>SetResolutionScaleValue</summary>
	public void SetResolutionScaleValue(int NewScaleValue) {}
	///<summary>Sets the current resolution scale</summary>
	public void SetResolutionScaleValueEx(float NewScaleValue) {}
	///<summary>Sets the current resolution scale as a normalized 0..1 value between MinScaleValue and MaxScaleValue</summary>
	public void SetResolutionScaleNormalized(float NewScaleNormalized) {}
	///<summary>Sets the view distance quality (0..4, higher is better)</summary>
	public void SetViewDistanceQuality(int Value) {}
	///<summary>Returns the view distance quality (0..4, higher is better)</summary>
	public int GetViewDistanceQuality() { return default; }
	///<summary>Sets the shadow quality (0..4, higher is better)</summary>
	public void SetShadowQuality(int Value) {}
	///<summary>Returns the shadow quality (0..4, higher is better)</summary>
	public int GetShadowQuality() { return default; }
	///<summary>Sets the global illumination quality (0..4, higher is better)</summary>
	public void SetGlobalIlluminationQuality(int Value) {}
	///<summary>Returns the global illumination quality (0..4, higher is better)</summary>
	public int GetGlobalIlluminationQuality() { return default; }
	///<summary>Sets the reflection quality (0..4, higher is better)</summary>
	public void SetReflectionQuality(int Value) {}
	///<summary>Returns the reflection quality (0..4, higher is better)</summary>
	public int GetReflectionQuality() { return default; }
	///<summary>Sets the anti-aliasing quality (0..4, higher is better)</summary>
	public void SetAntiAliasingQuality(int Value) {}
	///<summary>Returns the anti-aliasing quality (0..4, higher is better)</summary>
	public int GetAntiAliasingQuality() { return default; }
	///<summary>Sets the texture quality (0..4, higher is better)</summary>
	public void SetTextureQuality(int Value) {}
	///<summary>Returns the texture quality (0..4, higher is better)</summary>
	public int GetTextureQuality() { return default; }
	///<summary>Sets the visual effects quality (0..4, higher is better)</summary>
	public void SetVisualEffectQuality(int Value) {}
	///<summary>Returns the visual effects quality (0..4, higher is better)</summary>
	public int GetVisualEffectQuality() { return default; }
	///<summary>Sets the post-processing quality (0..4, higher is better)</summary>
	public void SetPostProcessingQuality(int Value) {}
	///<summary>Returns the post-processing quality (0..4, higher is better)</summary>
	public int GetPostProcessingQuality() { return default; }
	///<summary>Sets the foliage quality (0..4, higher is better)</summary>
	public void SetFoliageQuality(int Value) {}
	///<summary>Returns the foliage quality (0..4, higher is better)</summary>
	public int GetFoliageQuality() { return default; }
	///<summary>Sets the shading quality (0..4, higher is better)</summary>
	public void SetShadingQuality(int Value) {}
	///<summary>Returns the shading quality (0..4, higher is better)</summary>
	public int GetShadingQuality() { return default; }
	///<summary>Checks if any user settings is different from current</summary>
	public virtual bool IsDirty() { return default; }
	///<summary>Validates and resets bad user settings to default. Deletes stale user settings file if necessary.</summary>
	public virtual void ValidateSettings() {}
	///<summary>Loads the user settings from persistent storage</summary>
	public virtual void LoadSettings(bool bForceReload/*=false*/) {}
	///<summary>Save the user settings to persistent storage (automatically happens as part of ApplySettings)</summary>
	public virtual void SaveSettings() {}
	///<summary>This function resets all settings to the current system settings</summary>
	public virtual void ResetToCurrentSettings() {}
	///<summary>SetToDefaults</summary>
	public virtual void SetToDefaults() {}
	///<summary>Gets the desired resolution quality based on DesiredScreenWidth/Height and the current screen resolution</summary>
	public virtual float GetDefaultResolutionScale() { return default; }
	///<summary>Gets the recommended resolution quality based on LastRecommendedScreenWidth/Height and the current screen resolution</summary>
	public virtual float GetRecommendedResolutionScale() { return default; }
	///<summary>Returns the default resolution when no resolution is set</summary>
	public static FIntPoint GetDefaultResolution() { return default; }
	///<summary>Returns the default window position when no position is set</summary>
	public static FIntPoint GetDefaultWindowPosition() { return default; }
	///<summary>Returns the default window mode when no mode is set</summary>
	public static EWindowMode GetDefaultWindowMode() { return default; }
	///<summary>GetSyncInterval</summary>
	public static int GetSyncInterval() { return default; }
	///<summary>Gets the current frame pacing frame rate in fps, or 0 if none</summary>
	public static int GetFramePace() { return default; }
	///<summary>Returns the game local machine settings (resolution, windowing mode, scalability settings, etc...)</summary>
	public static UGameUserSettings GetGameUserSettings() { return default; }
	///<summary>Runs the hardware benchmark and populates ScalabilityQuality as well as the last benchmark results config members, but does not apply the settings it determines. Designed to be called in conjunction with ApplyHardwareBenchmarkResults</summary>
	public virtual void RunHardwareBenchmark(int WorkScale/*=10*/,float CPUMultiplier/*=1.0f*/,float GPUMultiplier/*=1.0f*/) {}
	///<summary>Applies the settings stored in ScalabilityQuality and saves settings</summary>
	public virtual void ApplyHardwareBenchmarkResults() {}
	///<summary>Whether the curently running system supports HDR display output</summary>
	public virtual bool SupportsHDRDisplayOutput() { return default; }
	///<summary>Enables or disables HDR display output. Can be called again to change the desired nit level</summary>
	public void EnableHDRDisplayOutput(bool bEnable,int DisplayNits/*=1000*/) {}
	///<summary>Returns 0 if HDR isn&#39;t supported or is turned off</summary>
	public int GetCurrentHDRDisplayNits() { return default; }
	///<summary>IsHDREnabled</summary>
	public bool IsHDREnabled() { return default; }
	///<summary>Whether to use VSync or not. (public to allow UI to connect to it)</summary>
	public bool bUseVSync;
	///<summary>Whether to use dynamic resolution or not. (public to allow UI to connect to it)</summary>
	public bool bUseDynamicResolution;
	///<summary>Game screen resolution width, in pixels.</summary>
	public uint ResolutionSizeX;
	///<summary>Game screen resolution height, in pixels.</summary>
	public uint ResolutionSizeY;
	///<summary>Game screen resolution width, in pixels.</summary>
	public uint LastUserConfirmedResolutionSizeX;
	///<summary>Game screen resolution height, in pixels.</summary>
	public uint LastUserConfirmedResolutionSizeY;
	///<summary>Window PosX</summary>
	public int WindowPosX;
	///<summary>Window PosY</summary>
	public int WindowPosY;
	///<summary>Game window fullscreen mode</summary>
	public int FullscreenMode;
	///<summary>Last user confirmed fullscreen mode setting.</summary>
	public int LastConfirmedFullscreenMode;
	///<summary>Fullscreen mode to use when toggling between windowed and fullscreen. Same values as r.FullScreenMode.</summary>
	public int PreferredFullscreenMode;
	///<summary>All settings will be wiped and set to default if the serialized version differs from UE_GAMEUSERSETTINGS_VERSION.</summary>
	public uint Version;
	///<summary>AudioQualityLevel</summary>
	public int AudioQualityLevel;
	///<summary>LastConfirmedAudioQualityLevel</summary>
	public int LastConfirmedAudioQualityLevel;
	///<summary>Frame rate cap</summary>
	public float FrameRateLimit;
	///<summary>Desired screen width used to calculate the resolution scale when user changes display mode</summary>
	public int DesiredScreenWidth;
	///<summary>If true, the desired screen height will be used to scale the render resolution automatically.</summary>
	public bool bUseDesiredScreenHeight;
	///<summary>Desired screen height used to calculate the resolution scale when user changes display mode</summary>
	public int DesiredScreenHeight;
	///<summary>Desired screen width used to calculate the resolution scale when user changes display mode</summary>
	public int LastUserConfirmedDesiredScreenWidth;
	///<summary>Desired screen height used to calculate the resolution scale when user changes display mode</summary>
	public int LastUserConfirmedDesiredScreenHeight;
	///<summary>Result of the last benchmark; calculated resolution to use.</summary>
	public float LastRecommendedScreenWidth;
	///<summary>Result of the last benchmark; calculated resolution to use.</summary>
	public float LastRecommendedScreenHeight;
	///<summary>Result of the last benchmark (CPU); -1 if there has not been a benchmark run</summary>
	public float LastCPUBenchmarkResult;
	///<summary>Result of the last benchmark (GPU); -1 if there has not been a benchmark run</summary>
	public float LastGPUBenchmarkResult;
	///<summary>Result of each individual sub-section of the last CPU benchmark; empty if there has not been a benchmark run</summary>
	public TArray<float> LastCPUBenchmarkSteps;
	///<summary>Result of each individual sub-section of the last GPU benchmark; empty if there has not been a benchmark run</summary>
	public TArray<float> LastGPUBenchmarkSteps;
	///<summary>Multiplier used against the last GPU benchmark</summary>
	public float LastGPUBenchmarkMultiplier;
	///<summary>HDR</summary>
	public bool bUseHDRDisplayOutput;
	///<summary>HDR</summary>
	public int HDRDisplayOutputNits;
	///<summary>OnGameUserSettingsUINeedsUpdate</summary>
	public FOnGameUserSettingsUINeedsUpdate OnGameUserSettingsUINeedsUpdate;
}
