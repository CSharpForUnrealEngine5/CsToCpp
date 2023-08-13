namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceActor.h")]
public partial class ULevelSequenceBurnInOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Loads the specified class path and initializes an instance, then stores it in Settings.</summary>
	public void SetBurnIn(FSoftClassPath InBurnInClass) {}
	///<summary>bUseBurnIn</summary>
	public bool bUseBurnIn;
	///<summary>BurnInClass</summary>
	public FSoftClassPath BurnInClass;
	///<summary>Settings</summary>
	public ULevelSequenceBurnInInitSettings Settings;
}
