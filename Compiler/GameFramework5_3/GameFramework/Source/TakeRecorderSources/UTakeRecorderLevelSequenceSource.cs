namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Plays level sequence actors when recording starts</summary>
[CppInclude("TakeRecorderLevelSequenceSource.h")]
public partial class UTakeRecorderLevelSequenceSource : UTakeRecorderSource {
	public static UClass StaticClass() {return default;}
	///<summary>LevelSequencesToTrigger</summary>
	public TArray<ULevelSequence> LevelSequencesToTrigger;
}
