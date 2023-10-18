namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the media profile in the editor or standalone.</summary>
[CppInclude("Profile/MediaProfileSettings.h")]
public partial class UMediaProfileEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Display the media profile icon in the editor toolbar.</summary>
	public bool bDisplayInToolbar;
	///<summary>When enabled, the media profile name will be displayed in the main editor UI.</summary>
	public bool bDisplayInMainEditor;
	///<summary>The media profile to use in standalone &amp; editor.</summary>
	public TSoftObjectPtr<UMediaProfile> UserMediaProfile;
}
