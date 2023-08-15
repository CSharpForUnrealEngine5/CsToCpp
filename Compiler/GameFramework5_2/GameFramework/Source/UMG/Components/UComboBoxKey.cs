namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The combobox allows you to display a list of options to the user in a dropdown menu for them to select one.</summary>
[CppInclude("Components/ComboBoxKey.h")]
public partial class UComboBoxKey : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>FOnSelectionChangedEvent</summary>
	public void FOnSelectionChangedEvent(FName SelectedItem,ESelectInfo SelectionType) {}
	///<summary>FOnOpeningEvent</summary>
	public void FOnOpeningEvent() {}
	///<summary>FGenerateWidgetEvent</summary>
	public UWidget FGenerateWidgetEvent(FName Item) { return default; }
	///<summary>Options</summary>
	public TArray<FName> Options;
	///<summary>SelectedOption</summary>
	public FName SelectedOption;
	///<summary>The combobox style.</summary>
	public FComboBoxStyle WidgetStyle;
	///<summary>The item row style.</summary>
	public FTableRowStyle ItemStyle;
	///<summary>The scroll bar style.</summary>
	public FScrollBarStyle ScrollBarStyle;
	///<summary>The foreground color to pass through the hierarchy.</summary>
	public FSlateColor ForegroundColor;
	///<summary>ContentPadding</summary>
	public FMargin ContentPadding;
	///<summary>The max height of the combobox list that opens</summary>
	public float MaxListHeight;
	///<summary>When false, the down arrow is not generated and it is up to the API consumer</summary>
	public bool bHasDownArrow;
	///<summary>When false, directional keys will change the selection. When true, ComboBox</summary>
	public bool bEnableGamepadNavigationMode;
	///<summary>When true, allows the combo box to receive keyboard focus</summary>
	public bool bIsFocusable;
	///<summary>Called when the widget is needed for the content.</summary>
	public FGenerateWidgetEvent OnGenerateContentWidget;
	///<summary>Called when the widget is needed for the item.</summary>
	public FGenerateWidgetEvent OnGenerateItemWidget;
	///<summary>Called when a new item is selected in the combobox.</summary>
	public FOnSelectionChangedEvent OnSelectionChanged;
	///<summary>Called when the combobox is opening</summary>
	public FOnOpeningEvent OnOpening;
	///<summary>Add an element to the option list.</summary>
	public void AddOption(FName Option) {}
	///<summary>Remove an element to the option list.</summary>
	public bool RemoveOption(FName Option) { return default; }
	///<summary>Remove all the elements of the option list.</summary>
	public void ClearOptions() {}
	///<summary>Clear the current selection.</summary>
	public void ClearSelection() {}
	///<summary>Set the current selected option.</summary>
	public void SetSelectedOption(FName Option) {}
	///<summary>Get the current selected option</summary>
	public FName GetSelectedOption() { return default; }
	///<summary>Is the combobox menu opened.</summary>
	public bool IsOpen() { return default; }
}
