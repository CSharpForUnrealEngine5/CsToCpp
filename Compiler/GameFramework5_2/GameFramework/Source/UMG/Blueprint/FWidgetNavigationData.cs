namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetNavigation.h")]
public partial struct FWidgetNavigationData {
	public EUINavigationRule Rule;
	public string WidgetToFocus;
	public TWeakObjectPtr<UWidget> Widget;
	public FCustomWidgetNavigationDelegate CustomDelegate;
}
