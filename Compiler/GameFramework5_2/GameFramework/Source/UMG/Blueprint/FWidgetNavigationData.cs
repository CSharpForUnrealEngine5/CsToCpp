#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetNavigation.h")]
public partial struct FWidgetNavigationData {
	public EUINavigationRule Rule;
	public string WidgetToFocus;
	public TWeakObjectPtr<UWidget> Widget;
	public FCustomWidgetNavigationDelegate CustomDelegate;
}
