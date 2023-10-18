namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerPlaylist.h")]
public partial class USequencerPlaylist : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Description</summary>
	public FText Description;
	///<summary>Items</summary>
	public TArray<USequencerPlaylistItem> Items;
}
