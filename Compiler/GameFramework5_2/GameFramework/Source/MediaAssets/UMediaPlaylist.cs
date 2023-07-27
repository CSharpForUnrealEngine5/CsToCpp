#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaPlaylist.h")]
///<summary>Implements a media play list.</summary>
public partial class UMediaPlaylist : UObject {
// MediaPlaylist
	public  bool Add(UMediaSource MediaSource) { return default; }
	public  bool AddFile(string FilePath) { return default; }
	public  bool AddUrl(string Url) { return default; }
	public  UMediaSource Get(int Index) { return default; }
	public  UMediaSource GetNext(int InOutIndex) { return default; }
	public  UMediaSource GetPrevious(int InOutIndex) { return default; }
	public  UMediaSource GetRandom(int OutIndex) { return default; }
	public  void Insert(UMediaSource MediaSource,int Index) {}
	public  int Num() { return default; }
	public  bool Remove(UMediaSource MediaSource) { return default; }
	public  bool RemoveAt(int Index) { return default; }
	public  bool Replace(int Index,UMediaSource Replacement) { return default; }
	public TArray<UMediaSource> Items;
}
