namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a media play list.</summary>
[CppInclude("MediaPlaylist.h")]
public partial class UMediaPlaylist : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Add a media source to the play list.</summary>
	public bool Add(UMediaSource MediaSource) { return default; }
	///<summary>Add a media file path to the play list.</summary>
	public bool AddFile(string FilePath) { return default; }
	///<summary>Add a media URL to the play list.</summary>
	public bool AddUrl(string Url) { return default; }
	///<summary>Get the media source at the specified index.</summary>
	public UMediaSource Get(int Index) { return default; }
	///<summary>Get the next media source in the play list.</summary>
	public UMediaSource GetNext(int InOutIndex) { return default; }
	///<summary>Get the previous media source in the play list.</summary>
	public UMediaSource GetPrevious(int InOutIndex) { return default; }
	///<summary>Get a random media source in the play list.</summary>
	public UMediaSource GetRandom(int OutIndex) { return default; }
	///<summary>Insert a media source into the play list at the given position.</summary>
	public void Insert(UMediaSource MediaSource,int Index) {}
	///<summary>Get the number of media sources in the play list.</summary>
	public int Num() { return default; }
	///<summary>Remove all occurrences of the given media source in the play list.</summary>
	public bool Remove(UMediaSource MediaSource) { return default; }
	///<summary>Remove the media source at the specified position.</summary>
	public bool RemoveAt(int Index) { return default; }
	///<summary>Replace the media source at the specified position.</summary>
	public bool Replace(int Index,UMediaSource Replacement) { return default; }
	///<summary>List of media sources to play.</summary>
	public TArray<UMediaSource> Items;
}
