namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Link To Set of Anim Sequences that we may be linked to.</summary>
[CppInclude("LevelSequenceAnimSequenceLink.h")]
public partial class ULevelSequenceAnimSequenceLink : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>AnimSequenceLinks</summary>
	public TArray<FLevelSequenceAnimSequenceLinkItem> AnimSequenceLinks;
}
