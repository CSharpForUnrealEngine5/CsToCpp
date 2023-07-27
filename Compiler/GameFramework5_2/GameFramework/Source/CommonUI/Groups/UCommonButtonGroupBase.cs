#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Groups/CommonButtonGroupBase.h")]
///<summary>Manages an arbitrary collection of CommonButton widgets.</summary>
public partial class UCommonButtonGroupBase : UCommonWidgetGroupBase {
// CommonButtonGroupBase
	public  void SetSelectionRequired(bool bRequireSelection) {}
	public  void DeselectAll() {}
	public  void SelectNextButton(bool bAllowWrap/*=true*/) {}
	public  void SelectPreviousButton(bool bAllowWrap/*=true*/) {}
	public  void SelectButtonAtIndex(int ButtonIndex,bool bAllowSound/*=true*/) {}
	public  int GetSelectedButtonIndex() { return default; }
	public  int GetHoveredButtonIndex() { return default; }
	public  int FindButtonIndex(UCommonButtonBase ButtonToFind) { return default; }
	public FSimpleButtonBaseGroupDelegate OnSelectedButtonBaseChanged;
	public FSimpleButtonBaseGroupDelegate OnHoveredButtonBaseChanged;
	public FSimpleButtonBaseGroupDelegate OnButtonBaseClicked;
	public FSimpleButtonBaseGroupDelegate OnButtonBaseDoubleClicked;
	public FOnSelectionCleared OnSelectionCleared;
	public  UCommonButtonBase GetButtonBaseAtIndex(int Index) { return default; }
	public  UCommonButtonBase GetSelectedButtonBase() { return default; }
	public  bool HasAnyButtons() { return default; }
	public  int GetButtonCount() { return default; }
	public bool bSelectionRequired;
	public  void OnSelectionStateChangedBase(UCommonButtonBase BaseButton,bool bIsSelected) {}
	public  void OnHandleButtonBaseClicked(UCommonButtonBase BaseButton) {}
	public  void OnHandleButtonBaseDoubleClicked(UCommonButtonBase BaseButton) {}
	public  void OnButtonBaseHovered(UCommonButtonBase BaseButton) {}
	public  void OnButtonBaseUnhovered(UCommonButtonBase BaseButton) {}
}
