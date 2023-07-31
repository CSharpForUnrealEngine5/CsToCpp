#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceActor.h")]
public partial class ULevelSequenceBurnInOptions : UObject {
	///<summary>Loads the specified class path and initializes an instance, then stores it in Settings.</summary>
	public  void SetBurnIn(FSoftClassPath InBurnInClass) {}
	///<summary>bUseBurnIn</summary>
	public bool bUseBurnIn;
	///<summary>BurnInClass</summary>
	public FSoftClassPath BurnInClass;
	///<summary>Settings</summary>
	public ULevelSequenceBurnInInitSettings Settings;
}
