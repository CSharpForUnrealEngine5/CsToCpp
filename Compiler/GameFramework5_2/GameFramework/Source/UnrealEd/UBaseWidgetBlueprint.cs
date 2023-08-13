namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseWidgetBlueprint.h")]
public partial class UBaseWidgetBlueprint : UUserWidgetBlueprint {
	public static UClass StaticClass() {return default;}
	///<summary>A tree of the widget templates to be created</summary>
	public UWidgetTree WidgetTree;
}
