#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A named bundle of lens settings used to implement lens presets.</summary>
[CppInclude("CineCameraSettings.h")]
public partial struct FNamedLensPreset {
	public string Name;
	public FCameraLensSettings LensSettings;
}
