namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represent a Widget present in the Tree Widget of the UserWidget</summary>
[CppInclude("Blueprint/WidgetChild.h")]
public partial struct FWidgetChild {
	public FName WidgetName;
	public TWeakObjectPtr<UWidget> WidgetPtr;
}
