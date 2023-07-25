#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeSettings.h")]
public partial class USoundscapeSettings : UDeveloperSettings {
// SoundscapeSettings
	public TSet<FSoftObjectPath> SoundscapePaletteCollection;
	public bool bDebugDraw;
	public float LOD1ColorPointHashWidth;
	public float LOD1ColorPointHashDistance;
	public float LOD2ColorPointHashWidth;
	public float LOD2ColorPointHashDistance;
	public float LOD3ColorPointHashWidth;
	public float ActiveColorPointHashWidth;
	public float ActiveColorPointHashUpdateTimeSeconds;
}
