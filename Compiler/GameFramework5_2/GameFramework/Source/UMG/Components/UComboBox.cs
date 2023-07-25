#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ComboBox.h")]
///<summary>The combobox allows you to display a list of options to the user in a dropdown menu for them to select one.</summary>
public partial class UComboBox : UWidget {
// ComboBox
	public FScrollBarStyle ScrollBarStyle;
	public TArray<UObject> Items;
	public FGenerateWidgetForObject OnGenerateWidgetEvent;
	public bool bIsFocusable;
}
