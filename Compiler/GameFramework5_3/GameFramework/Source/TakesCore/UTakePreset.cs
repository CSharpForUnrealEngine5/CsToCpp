namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Take preset that is stored as an asset comprising a ULevelSequence, and a set of actor recording sources</summary>
[CppInclude("TakePreset.h")]
public partial class UTakePreset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Instanced level sequence template that is used to define a starting point for a new take recording</summary>
	public ULevelSequence LevelSequence;
}
