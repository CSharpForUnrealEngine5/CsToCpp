namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineConfigBase.h")]
public partial class UMoviePipelineConfigBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Removes the specific instance from our Setting list.</summary>
	public virtual void RemoveSetting(UMoviePipelineSetting InSetting) {}
	///<summary>Copy this configuration from another existing configuration.</summary>
	public virtual void CopyFrom(UMoviePipelineConfigBase InConfig) {}
	///<summary>Returns an array of all settings in this config that the user has added via the UI or via Scripting.</summary>
	public virtual TArray<UMoviePipelineSetting> GetUserSettings() { return default; }
	///<summary>Gets the config that this config was originally based on (if any). The origin will only be set on transient</summary>
	public UMoviePipelineConfigBase GetConfigOrigin() { return default; }
	///<summary>Sets the config that this config originated from (if any). The origin should only be set for transient configs.</summary>
	public void SetConfigOrigin(UMoviePipelineConfigBase InConfig) {}
	///<summary>Find all settings of a particular type for this config.</summary>
	public TArray<UMoviePipelineSetting> FindSettingsByClass(UClass InClass,bool bIncludeDisabledSettings/*=false*/,bool bExactMatch/*=false*/) { return default; }
	///<summary>Find a setting of a particular type for this config.</summary>
	public UMoviePipelineSetting FindSettingByClass(UClass InClass,bool bIncludeDisabledSettings/*=false*/,bool bExactMatch/*=false*/) { return default; }
	///<summary>Finds a setting of a particular type for this pipeline config, adding it if it doesn&#39;t already exist.</summary>
	public UMoviePipelineSetting FindOrAddSettingByClass(UClass InClass,bool bIncludeDisabledSettings/*=false*/,bool bExactMatch/*=false*/) { return default; }
	///<summary>DisplayName</summary>
	public string DisplayName;
	///<summary>Array of settings classes that affect various parts of the output pipeline.</summary>
	public TArray<UMoviePipelineSetting> Settings;
	///<summary>The config that this config originated from. Helpful for transient configs.</summary>
	public TSoftObjectPtr<UMoviePipelineConfigBase> ConfigOrigin;
}
