#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Level Sequence With Shots Settings.</summary>
[CppInclude("Misc/LevelSequenceEditorSettings.h")]
public partial class ULevelSequenceWithShotsSettings : UObject {
	///<summary>Sequence With Shots name.</summary>
	public string Name;
	///<summary>Sequence With Shots suffix.</summary>
	public string Suffix;
	///<summary>Sequence With Shots path.</summary>
	public FDirectoryPath BasePath;
	///<summary>Sequence With Shots number of shots.</summary>
	public uint NumShots;
	///<summary>Sequence With Shots level sequence to duplicate when creating shots.</summary>
	public TLazyObjectPtr<ULevelSequence> SequenceToDuplicate;
	///<summary>Array of sub sequence names, each will result in a level sequence asset in the shot.</summary>
	public TArray<string> SubSequenceNames;
	///<summary>Whether to instance sub sequences based on the first created sub sequences.</summary>
	public bool bInstanceSubSequences;
}
