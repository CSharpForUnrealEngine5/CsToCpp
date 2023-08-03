#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a section in sub-sequence tracks.</summary>
[CppInclude("Sections/MovieSceneSubSection.h")]
public partial class UMovieSceneSubSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Get the sequence that is assigned to this section.</summary>
	public  UMovieSceneSequence GetSequence() { return default; }
	///<summary>Sets the sequence played by this section.</summary>
	public  void SetSequence(UMovieSceneSequence Sequence) {}
	///<summary>Parameters</summary>
	public FMovieSceneSectionParameters Parameters;
	///<summary>StartOffset_DEPRECATED</summary>
	public float StartOffset_DEPRECATED;
	///<summary>TimeScale_DEPRECATED</summary>
	public float TimeScale_DEPRECATED;
	///<summary>PrerollTime_DEPRECATED</summary>
	public float PrerollTime_DEPRECATED;
	///<summary>NetworkMask</summary>
	public byte NetworkMask;
	///<summary>Movie scene being played by this section</summary>
	public UMovieSceneSequence SubSequence;
}
