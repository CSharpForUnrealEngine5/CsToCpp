#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneSubSection.h")]
///<summary>Implements a section in sub-sequence tracks.</summary>
public partial class UMovieSceneSubSection : UMovieSceneSection {
// MovieSceneSubSection
	public  UMovieSceneSequence GetSequence() { return default; }
	public  void SetSequence(UMovieSceneSequence Sequence) {}
	public FMovieSceneSectionParameters Parameters;
	public float StartOffset_DEPRECATED;
	public float TimeScale_DEPRECATED;
	public float PrerollTime_DEPRECATED;
	public byte NetworkMask;
	public UMovieSceneSequence SubSequence;
}
