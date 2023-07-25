#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetNavigation.h")]
public partial struct FWidgetNavigationData {
// WidgetNavigationData
	public EUINavigationRule Rule;
	public string WidgetToFocus;
	public TWeakObjectPtr<UWidget> Widget;
	public FCustomWidgetNavigationDelegate CustomDelegate;
}
