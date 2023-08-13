namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Player.h")]
public partial class UPlayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The actor this player controls.</summary>
	public APlayerController PlayerController;
	///<summary>the current speed of the connection</summary>
	public int CurrentNetSpeed;
	///<summary>@todo document</summary>
	public int ConfiguredInternetSpeed;
	///<summary>@todo document</summary>
	public int ConfiguredLanSpeed;
}
