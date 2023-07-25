#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/InputTestFramework.h")]
public partial class UControllablePlayer : UObject {
// ControllablePlayer
	public APlayerController Player;
	public TMap<string,FBindingTargets> BindingTargets;
	public TMap<string,UInputMappingContext> InputContext;
	public TMap<string,UInputAction> InputAction;
}
