namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class acts as a base class for a save game object that can be used to save state about the game.</summary>
[CppInclude("GameFramework/SaveGame.h")]
public partial class USaveGame : UObject {
	public static UClass StaticClass() {return default;}
}
