namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The combobox allows you to display a list of options to the user in a dropdown menu for them to select one.</summary>
[CppInclude("Components/ComboBoxString.h")]
public partial class UComboBoxString : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>FOnSelectionChangedEvent</summary>
	public void FOnSelectionChangedEvent(string SelectedItem,ESelectInfo SelectionType) {}
	///<summary>FOnOpeningEvent</summary>
	public void FOnOpeningEvent() {}
	///<summary>The default list of items to be displayed on the combobox.</summary>
	public TArray<string> DefaultOptions;
	///<summary>The item in the combobox to select by default</summary>
	public string SelectedOption;
	///<summary>The style.</summary>
	public FComboBoxStyle WidgetStyle;
	///<summary>The item row style.</summary>
	public FTableRowStyle ItemStyle;
	///<summary>The scroll bar style.</summary>
	public FScrollBarStyle ScrollBarStyle;
	///<summary>ContentPadding</summary>
	public FMargin ContentPadding;
	///<summary>The max height of the combobox list that opens</summary>
	public float MaxListHeight;
	///<summary>When false, the down arrow is not generated and it is up to the API consumer</summary>
	public bool HasDownArrow;
	///<summary>When false, directional keys will change the selection. When true, ComboBox</summary>
	public bool EnableGamepadNavigationMode;
	///<summary>The default font to use in the combobox, only applies if you&#39;re not implementing OnGenerateWidgetEvent</summary>
	public FSlateFontInfo Font;
	///<summary>The foreground color to pass through the hierarchy.</summary>
	public FSlateColor ForegroundColor;
	///<summary>bIsFocusable</summary>
	public bool bIsFocusable;
	///<summary>Called when the widget is needed for the item.</summary>
	public FGenerateWidgetForString OnGenerateWidgetEvent;
	///<summary>Called when a new item is selected in the combobox.</summary>
	public FOnSelectionChangedEvent OnSelectionChanged;
	///<summary>Called when the combobox is opening</summary>
	public FOnOpeningEvent OnOpening;
	///<summary>AddOption</summary>
	public void AddOption(string Option) {}
	///<summary>RemoveOption</summary>
	public bool RemoveOption(string Option) { return default; }
	///<summary>FindOptionIndex</summary>
	public int FindOptionIndex(string Option) { return default; }
	///<summary>GetOptionAtIndex</summary>
	public string GetOptionAtIndex(int Index) { return default; }
	///<summary>ClearOptions</summary>
	public void ClearOptions() {}
	///<summary>ClearSelection</summary>
	public void ClearSelection() {}
	///<summary>Refreshes the list of options.  If you added new ones, and want to update the list even if it&#39;s</summary>
	public void RefreshOptions() {}
	///<summary>SetSelectedOption</summary>
	public void SetSelectedOption(string Option) {}
	///<summary>SetSelectedIndex</summary>
	public void SetSelectedIndex(int Index) {}
	///<summary>GetSelectedOption</summary>
	public string GetSelectedOption() { return default; }
	///<summary>GetSelectedIndex</summary>
	public int GetSelectedIndex() { return default; }
	///<summary>Returns the number of options</summary>
	public int GetOptionCount() { return default; }
	///<summary>IsOpen</summary>
	public bool IsOpen() { return default; }
}
