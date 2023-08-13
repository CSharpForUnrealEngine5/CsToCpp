namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A named bundle of crop settings used to implement crop presets.</summary>
[CppInclude("CineCameraSettings.h")]
public partial struct FNamedPlateCropPreset {
	public string Name;
	public FPlateCropSettings CropSettings;
}
