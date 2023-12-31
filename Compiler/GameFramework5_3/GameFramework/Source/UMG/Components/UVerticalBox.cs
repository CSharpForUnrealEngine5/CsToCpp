namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A vertical box widget is a layout panel allowing child widgets to be automatically laid out</summary>
[CppInclude("Components/VerticalBox.h")]
public partial class UVerticalBox : UPanelWidget {
	public static UClass StaticClass() {return default;}
	///<summary>AddChildToVerticalBox</summary>
	public UVerticalBoxSlot AddChildToVerticalBox(UWidget Content) { return default; }
}
