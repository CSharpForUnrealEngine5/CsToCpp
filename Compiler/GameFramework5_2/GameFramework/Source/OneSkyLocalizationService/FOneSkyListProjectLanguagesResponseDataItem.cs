#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyListProjectLanguagesResponseDataItem {
	public string code;
	public string english_name;
	public string local_name;
	public string locale;
	public string region;
	public bool is_base_language;
	public bool is_ready_to_publish;
	public string translation_progress;
}
