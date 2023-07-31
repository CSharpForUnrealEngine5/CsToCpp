#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneGeometryCacheSection.h")]
public partial struct FMovieSceneGeometryCacheParams {
	public UGeometryCache GeometryCacheAsset;
	public FFrameNumber FirstLoopStartFrameOffset;
	public FFrameNumber StartFrameOffset;
	public FFrameNumber EndFrameOffset;
	public float PlayRate;
	public bool bReverse;
	public float StartOffset_DEPRECATED;
	public float EndOffset_DEPRECATED;
	public FSoftObjectPath GeometryCache_DEPRECATED;
}
