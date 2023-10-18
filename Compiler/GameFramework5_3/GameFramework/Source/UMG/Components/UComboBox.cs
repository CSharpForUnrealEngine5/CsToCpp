namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The combobox allows you to display a list of options to the user in a dropdown menu for them to select one.</summary>
[CppInclude("Components/ComboBox.h")]
public partial class UComboBox : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>ScrollBarStyle</summary>
	public FScrollBarStyle ScrollBarStyle;
	///<summary>The list of items to be displayed on the combobox.</summary>
	public TArray<UObject> Items;
	///<summary>Called when the widget is needed for the item.</summary>
	public FGenerateWidgetForObject OnGenerateWidgetEvent;
	///<summary>bIsFocusable</summary>
	public bool bIsFocusable;
}
