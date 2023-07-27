#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ComboBoxString.h")]
///<summary>The combobox allows you to display a list of options to the user in a dropdown menu for them to select one.</summary>
public partial class UComboBoxString : UWidget {
// ComboBoxString
	public  void FOnSelectionChangedEvent(string SelectedItem,ESelectInfo SelectionType) {}
	public  void FOnOpeningEvent() {}
	public TArray<string> DefaultOptions;
	public string SelectedOption;
	public FComboBoxStyle WidgetStyle;
	public FTableRowStyle ItemStyle;
	public FScrollBarStyle ScrollBarStyle;
	public FMargin ContentPadding;
	public float MaxListHeight;
	public bool HasDownArrow;
	public bool EnableGamepadNavigationMode;
	public FSlateFontInfo Font;
	public FSlateColor ForegroundColor;
	public bool bIsFocusable;
	public FGenerateWidgetForString OnGenerateWidgetEvent;
	public FOnSelectionChangedEvent OnSelectionChanged;
	public FOnOpeningEvent OnOpening;
	public  void AddOption(string Option) {}
	public  bool RemoveOption(string Option) { return default; }
	public  int FindOptionIndex(string Option) { return default; }
	public  string GetOptionAtIndex(int Index) { return default; }
	public  void ClearOptions() {}
	public  void ClearSelection() {}
	public  void RefreshOptions() {}
	public  void SetSelectedOption(string Option) {}
	public  void SetSelectedIndex(int Index) {}
	public  string GetSelectedOption() { return default; }
	public  int GetSelectedIndex() { return default; }
	public  int GetOptionCount() { return default; }
	public  bool IsOpen() { return default; }
}
