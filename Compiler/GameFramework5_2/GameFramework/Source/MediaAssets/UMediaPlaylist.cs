#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaPlaylist.h")]
///<summary>Implements a media play list.</summary>
public partial class UMediaPlaylist : UObject {
// MediaPlaylist
	public bool Add(UObject MediaSource) { return default; }
	public bool AddFile(string FilePath) { return default; }
	public bool AddUrl(string Url) { return default; }
	public UObject Get(int Index) { return default; }
	public UObject GetNext(int InOutIndex) { return default; }
	public UObject GetPrevious(int InOutIndex) { return default; }
	public UObject GetRandom(int OutIndex) { return default; }
	public void Insert(UObject MediaSource,int Index) {}
	public int Num() { return default; }
	public bool Remove(UObject MediaSource) { return default; }
	public bool RemoveAt(int Index) { return default; }
	public bool Replace(int Index,UObject Replacement) { return default; }
	public TArray<UMediaSource> Items;
}
