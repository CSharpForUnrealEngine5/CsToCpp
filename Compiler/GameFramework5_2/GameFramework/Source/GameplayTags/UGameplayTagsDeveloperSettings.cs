namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagsSettings.h")]
public partial class UGameplayTagsDeveloperSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Allows new tags to be saved into their own INI file. This is make merging easier for non technical developers by setting up their own ini file.</summary>
	public string DeveloperConfigName;
	///<summary>Stores the favorite tag source, used as the default ini when adding new tags, can be toggled on/off using the button next to the tag source picker</summary>
	public string FavoriteTagSource;
}
