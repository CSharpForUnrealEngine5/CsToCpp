#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Profile/MediaProfileSettings.h")]
///<summary>Settings for the media profile in the editor or standalone.</summary>
public partial class UMediaProfileEditorSettings : UObject {
// MediaProfileEditorSettings
	public bool bDisplayInToolbar;
	public bool bDisplayInMainEditor;
	public TSoftObjectPtr<UMediaProfile> UserMediaProfile;
}
