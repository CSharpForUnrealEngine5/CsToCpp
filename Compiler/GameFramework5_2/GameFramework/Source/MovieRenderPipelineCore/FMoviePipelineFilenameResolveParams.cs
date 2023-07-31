#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieRenderPipelineDataTypes.h")]
public partial struct FMoviePipelineFilenameResolveParams {
	public int FrameNumber;
	public int FrameNumberShot;
	public int FrameNumberRel;
	public int FrameNumberShotRel;
	public string CameraNameOverride;
	public string ShotNameOverride;
	public int ZeroPadFrameNumberCount;
	public bool bForceRelativeFrameNumbers;
	public string FileNameOverride;
	public TMap<string,string> FileNameFormatOverrides;
	public TMap<string,string> FileMetadata;
	public FDateTime InitializationTime;
	public int InitializationVersion;
	public UMoviePipelineExecutorJob Job;
	public UMoviePipelineExecutorShot ShotOverride;
	public int AdditionalFrameNumberOffset;
}
