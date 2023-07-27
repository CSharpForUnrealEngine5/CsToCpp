#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineConfigBase.h")]
public partial class UMoviePipelineConfigBase : UObject {
// MoviePipelineConfigBase
	public  void RemoveSetting(UMoviePipelineSetting InSetting) {}
	public  void CopyFrom(UMoviePipelineConfigBase InConfig) {}
	public  TArray<UMoviePipelineSetting> GetUserSettings() { return default; }
	public  UMoviePipelineConfigBase GetConfigOrigin() { return default; }
	public  void SetConfigOrigin(UMoviePipelineConfigBase InConfig) {}
	public  TArray<UMoviePipelineSetting> FindSettingsByClass(UClass InClass,bool bIncludeDisabledSettings/*=false*/,bool bExactMatch/*=false*/) { return default; }
	public  UMoviePipelineSetting FindSettingByClass(UClass InClass,bool bIncludeDisabledSettings/*=false*/,bool bExactMatch/*=false*/) { return default; }
	public  UMoviePipelineSetting FindOrAddSettingByClass(UClass InClass,bool bIncludeDisabledSettings/*=false*/,bool bExactMatch/*=false*/) { return default; }
	public string DisplayName;
	public TArray<UMoviePipelineSetting> Settings;
	public TSoftObjectPtr<UMoviePipelineConfigBase> ConfigOrigin;
}
