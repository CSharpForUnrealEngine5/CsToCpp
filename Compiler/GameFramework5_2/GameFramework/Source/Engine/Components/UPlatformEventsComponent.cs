#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component to handle receiving notifications from the OS about platform events.</summary>
[CppInclude("Components/PlatformEventsComponent.h")]
public partial class UPlatformEventsComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Check whether a convertible laptop is laptop mode.</summary>
	public  bool IsInLaptopMode() { return default; }
	///<summary>Check whether a convertible laptop is laptop mode.</summary>
	public  bool IsInTabletMode() { return default; }
	///<summary>Check whether the platform supports convertible laptops.</summary>
	public  bool SupportsConvertibleLaptops() { return default; }
	///<summary>FPlatformEventDelegate</summary>
	public  void FPlatformEventDelegate() {}
	///<summary>This is called when a convertible laptop changed into laptop mode.</summary>
	public FPlatformEventDelegate PlatformChangedToLaptopModeDelegate;
	///<summary>This is called when a convertible laptop changed into tablet mode.</summary>
	public FPlatformEventDelegate PlatformChangedToTabletModeDelegate;
}
