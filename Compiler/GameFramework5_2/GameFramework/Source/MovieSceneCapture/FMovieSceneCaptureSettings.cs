#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneCaptureSettings.h")]
///<summary>Common movie-scene capture settings</summary>
public partial struct FMovieSceneCaptureSettings {
// MovieSceneCaptureSettings
	public FDirectoryPath OutputDirectory;
	public UClass GameModeOverride;
	public string OutputFormat;
	public bool bOverwriteExisting;
	public bool bUseRelativeFrameNumbers;
	public int HandleFrames;
	public string MovieExtension;
	public byte ZeroPadFrameNumbers;
	public FFrameRate FrameRate;
	public bool bUseCustomFrameRate;
	public FFrameRate CustomFrameRate;
	public FCaptureResolution Resolution;
	public bool bEnableTextureStreaming;
	public bool bCinematicEngineScalability;
	public bool bCinematicMode;
	public bool bAllowMovement;
	public bool bAllowTurning;
	public bool bShowPlayer;
	public bool bShowHUD;
	public bool bUsePathTracer;
	public int PathTracerSamplePerPixel;
}
