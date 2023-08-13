namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/UIFWidgetTree.h")]
public partial struct FUIFrameworkWidgetTreeEntry {
	public UUIFrameworkWidget Parent;
	public UUIFrameworkWidget Child;
	public FUIFrameworkWidgetId ParentId;
	public FUIFrameworkWidgetId ChildId;
}
