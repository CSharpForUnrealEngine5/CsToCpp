#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TextureEditorSettings.h")]
///<summary>Implements the Editor's user settings.</summary>
public partial class UTextureEditorSettings : UObject {
// TextureEditorSettings
	public ETextureEditorBackgrounds Background;
	public ETextureEditorSampling Sampling;
	public ETextureEditorVolumeViewMode VolumeViewMode;
	public ETextureEditorCubemapViewMode CubemapViewMode;
	public FColor BackgroundColor;
	public FColor CheckerColorOne;
	public FColor CheckerColorTwo;
	public int CheckerSize;
	public bool FitToViewport;
	public ETextureEditorZoomMode ZoomMode;
	public FColor TextureBorderColor;
	public bool TextureBorderEnabled;
}
