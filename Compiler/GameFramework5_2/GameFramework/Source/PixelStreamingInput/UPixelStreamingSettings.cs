#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Config loaded/saved to an .ini file.</summary>
[CppInclude("EditorPixelStreamingSettings.h")]
public partial class UPixelStreamingSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Pixel streaming always requires various software cursors so they will be</summary>
	public FSoftClassPath DefaultCursorClassName;
	///<summary>TextEditBeamCursorClassName</summary>
	public FSoftClassPath TextEditBeamCursorClassName;
	///<summary>Pixel Streaming can have a server-side cursor (where the cursor itself</summary>
	public FSoftClassPath HiddenCursorClassName;
	///<summary>Pixel Streaming may be running on a machine which has no physical mouse</summary>
	public bool bMouseAlwaysAttached;
}
