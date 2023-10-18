namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetNavigation.h")]
public partial struct FWidgetNavigationData {
	public EUINavigationRule Rule;
	public FName WidgetToFocus;
	public TWeakObjectPtr<UWidget> Widget;
	public FCustomWidgetNavigationDelegate CustomDelegate;
}
