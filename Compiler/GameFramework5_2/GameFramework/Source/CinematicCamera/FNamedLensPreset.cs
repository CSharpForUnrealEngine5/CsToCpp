namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A named bundle of lens settings used to implement lens presets.</summary>
[CppInclude("CineCameraSettings.h")]
public partial struct FNamedLensPreset {
	public string Name;
	public FCameraLensSettings LensSettings;
}
