#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A named bundle of filmback settings used to implement filmback presets</summary>
[CppInclude("CineCameraSettings.h")]
public partial struct FNamedFilmbackPreset {
	public string Name;
	public FCameraFilmbackSettings FilmbackSettings;
}
