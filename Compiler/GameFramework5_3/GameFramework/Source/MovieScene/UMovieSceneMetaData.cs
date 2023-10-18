namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene meta-data that is stored on UMovieScene assets</summary>
[CppInclude("MovieSceneMetaData.h")]
public partial class UMovieSceneMetaData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>@return The author for this metadata</summary>
	public string GetAuthor() { return default; }
	///<summary>@return The created date for this metadata</summary>
	public FDateTime GetCreated() { return default; }
	///<summary>@return The notes for this metadata</summary>
	public string GetNotes() { return default; }
	///<summary>Set this metadata&#39;s author</summary>
	public void SetAuthor(string InAuthor) {}
	///<summary>Set this metadata&#39;s created date</summary>
	public void SetCreated(FDateTime InCreated) {}
	///<summary>Set this metadata&#39;s notes</summary>
	public void SetNotes(string InNotes) {}
	///<summary>The author that created this metadata</summary>
	public string Author;
	///<summary>The created date at which the metadata was initiated</summary>
	public FDateTime Created;
	///<summary>Notes for the metadata</summary>
	public string Notes;
}
