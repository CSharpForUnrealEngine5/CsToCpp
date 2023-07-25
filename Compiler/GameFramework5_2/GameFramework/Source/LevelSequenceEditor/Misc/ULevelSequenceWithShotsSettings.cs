#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Misc/LevelSequenceEditorSettings.h")]
///<summary>Level Sequence With Shots Settings.</summary>
public partial class ULevelSequenceWithShotsSettings : UObject {
// LevelSequenceWithShotsSettings
	public string Name;
	public string Suffix;
	public FDirectoryPath BasePath;
	public uint NumShots;
	public TLazyObjectPtr<ULevelSequence> SequenceToDuplicate;
	public TArray<string> SubSequenceNames;
	public bool bInstanceSubSequences;
}
