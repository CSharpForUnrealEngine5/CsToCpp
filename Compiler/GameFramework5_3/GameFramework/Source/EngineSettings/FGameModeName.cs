namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper structure, used to associate GameModes with shortcut names.</summary>
[CppInclude("GameMapsSettings.h")]
public partial struct FGameModeName {
	public string Name;
	public FSoftClassPath GameMode;
}
