namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* This data structure contains all of the information needed to resolve a filename format string from the Movie Graph.</summary>
[CppInclude("Graph/MovieGraphFilenameResolveParams.h")]
public partial struct FMovieGraphFilenameResolveParams {
	public FMovieGraphRenderDataIdentifier RenderDataIdentifier;
	public int RootFrameNumber;
	public int ShotFrameNumber;
	public int RootFrameNumberRel;
	public int ShotFrameNumberRel;
	public TMap<string,string> FileMetadata;
	public int Version;
	public bool bForceRelativeFrameNumbers;
	public bool bEnsureAbsolutePath;
	public FDateTime InitializationTime;
	public int ZeroPadFrameNumberCount;
	public TMap<string,string> FileNameFormatOverrides;
	public UMoviePipelineExecutorJob Job;
	public UMoviePipelineExecutorShot Shot;
	public UMovieGraphEvaluatedConfig EvaluatedConfig;
	public int FrameNumberOffset;
	public FFrameRate DefaultFrameRate;
}
