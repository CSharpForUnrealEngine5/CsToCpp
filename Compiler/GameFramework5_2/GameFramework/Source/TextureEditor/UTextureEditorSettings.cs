namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Editor&#39;s user settings.</summary>
[CppInclude("TextureEditorSettings.h")]
public partial class UTextureEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The type of background to draw in the texture editor view port.</summary>
	public ETextureEditorBackgrounds Background;
	///<summary>The texture sampling mode used to render textures in the texture editor view port.</summary>
	public ETextureEditorSampling Sampling;
	///<summary>The view mode when previewing volume textures.</summary>
	public ETextureEditorVolumeViewMode VolumeViewMode;
	///<summary>The view mode when previewing cubemap textures.</summary>
	public ETextureEditorCubemapViewMode CubemapViewMode;
	///<summary>Background and foreground color used by Texture preview view ports.</summary>
	public FColor BackgroundColor;
	///<summary>The first color of the checkered background.</summary>
	public FColor CheckerColorOne;
	///<summary>The second color of the checkered background.</summary>
	public FColor CheckerColorTwo;
	///<summary>The size of the checkered background tiles.</summary>
	public int CheckerSize;
	///<summary>FitToViewport</summary>
	public bool FitToViewport;
	///<summary>Whether the texture should scale to fit or fill the view port, or use a custom zoom level.</summary>
	public ETextureEditorZoomMode ZoomMode;
	///<summary>Color to use for the texture border, if enabled.</summary>
	public FColor TextureBorderColor;
	///<summary>If true, displays a border around the texture.</summary>
	public bool TextureBorderEnabled;
}
