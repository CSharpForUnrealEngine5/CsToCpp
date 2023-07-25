#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimSequenceLevelSequenceLink.h")]
///<summary>Link To Level Sequence That may be driving the anim sequence</summary>
public partial class UAnimSequenceLevelSequenceLink : UAssetUserData {
// AnimSequenceLevelSequenceLink
	public FGuid SkelTrackGuid;
	public FSoftObjectPath PathToLevelSequence;
}
