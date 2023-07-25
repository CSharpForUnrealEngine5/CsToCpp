#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Player.h")]
public partial class UPlayer : UObject {
// Player
	public APlayerController PlayerController;
	public int CurrentNetSpeed;
	public int ConfiguredInternetSpeed;
	public int ConfiguredLanSpeed;
}
