namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A level blueprint is a specialized type of blueprint. It is used to house</summary>
[CppInclude("Engine/LevelScriptBlueprint.h")]
public partial class ULevelScriptBlueprint : UBlueprint {
	public static UClass StaticClass() {return default;}
	///<summary>The friendly name to use for UI</summary>
	public string FriendlyName;
}
