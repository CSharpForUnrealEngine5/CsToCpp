#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerTrackBP.h")]
public partial class USequencerTrackBP : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>bSupportsMultipleRows</summary>
	public bool bSupportsMultipleRows;
	///<summary>bSupportsBlending</summary>
	public bool bSupportsBlending;
	///<summary>TrackType</summary>
	public ECustomSequencerTrackType TrackType;
	///<summary>SupportedObjectType</summary>
	public UClass SupportedObjectType;
	///<summary>DefaultSectionType</summary>
	public UClass DefaultSectionType;
	///<summary>SupportedSections</summary>
	public TArray<UClass> SupportedSections;
	///<summary>TrackInstanceType</summary>
	public UClass TrackInstanceType;
	///<summary>Icon</summary>
	public FSlateBrush Icon;
	///<summary>Sections</summary>
	public TArray<UMovieSceneSection> Sections;
}
