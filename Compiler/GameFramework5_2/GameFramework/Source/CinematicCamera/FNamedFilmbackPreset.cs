namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A named bundle of filmback settings used to implement filmback presets</summary>
[CppInclude("CineCameraSettings.h")]
public partial struct FNamedFilmbackPreset {
	public string Name;
	public FCameraFilmbackSettings FilmbackSettings;
}
