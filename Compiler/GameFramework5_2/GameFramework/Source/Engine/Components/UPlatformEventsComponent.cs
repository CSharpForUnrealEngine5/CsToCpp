#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PlatformEventsComponent.h")]
///<summary>Component to handle receiving notifications from the OS about platform events.</summary>
public partial class UPlatformEventsComponent : UActorComponent {
// PlatformEventsComponent
	public  bool IsInLaptopMode() { return default; }
	public  bool IsInTabletMode() { return default; }
	public  bool SupportsConvertibleLaptops() { return default; }
	public  void FPlatformEventDelegate() {}
	public FPlatformEventDelegate PlatformChangedToLaptopModeDelegate;
	public FPlatformEventDelegate PlatformChangedToTabletModeDelegate;
}
