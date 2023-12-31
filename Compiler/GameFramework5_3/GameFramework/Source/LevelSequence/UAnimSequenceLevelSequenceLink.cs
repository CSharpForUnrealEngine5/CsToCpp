namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Link To Level Sequence That may be driving the anim sequence</summary>
[CppInclude("AnimSequenceLevelSequenceLink.h")]
public partial class UAnimSequenceLevelSequenceLink : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>SkelTrackGuid</summary>
	public FGuid SkelTrackGuid;
	///<summary>PathToLevelSequence</summary>
	public FSoftObjectPath PathToLevelSequence;
}
