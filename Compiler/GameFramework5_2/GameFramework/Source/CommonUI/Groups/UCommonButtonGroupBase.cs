namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manages an arbitrary collection of CommonButton widgets.</summary>
[CppInclude("Groups/CommonButtonGroupBase.h")]
public partial class UCommonButtonGroupBase : UCommonWidgetGroupBase {
	public static UClass StaticClass() {return default;}
	///<summary>Sets whether the group should always have a button selected.</summary>
	public void SetSelectionRequired(bool bRequireSelection) {}
	///<summary>Deselects all buttons in the group.</summary>
	public void DeselectAll() {}
	///<summary>Selects the next button in the group</summary>
	public void SelectNextButton(bool bAllowWrap/*=true*/) {}
	///<summary>Selects the previous button in the group</summary>
	public void SelectPreviousButton(bool bAllowWrap/*=true*/) {}
	///<summary>Selects a button at a specific index in the group. Clears all selection if given an invalid index.</summary>
	public void SelectButtonAtIndex(int ButtonIndex,bool bAllowSound/*=true*/) {}
	///<summary>Get the index of the currently selected button, if any.</summary>
	public int GetSelectedButtonIndex() { return default; }
	///<summary>Get the index of the currently hovered button, if any.</summary>
	public int GetHoveredButtonIndex() { return default; }
	///<summary>Find the button index of the specified button, if possible</summary>
	public int FindButtonIndex(UCommonButtonBase ButtonToFind) { return default; }
	///<summary>OnSelectedButtonBaseChanged</summary>
	public FSimpleButtonBaseGroupDelegate OnSelectedButtonBaseChanged;
	///<summary>OnHoveredButtonBaseChanged</summary>
	public FSimpleButtonBaseGroupDelegate OnHoveredButtonBaseChanged;
	///<summary>OnButtonBaseClicked</summary>
	public FSimpleButtonBaseGroupDelegate OnButtonBaseClicked;
	///<summary>OnButtonBaseDoubleClicked</summary>
	public FSimpleButtonBaseGroupDelegate OnButtonBaseDoubleClicked;
	///<summary>OnSelectionCleared</summary>
	public FOnSelectionCleared OnSelectionCleared;
	///<summary>GetButtonBaseAtIndex</summary>
	public UCommonButtonBase GetButtonBaseAtIndex(int Index) { return default; }
	///<summary>GetSelectedButtonBase</summary>
	public UCommonButtonBase GetSelectedButtonBase() { return default; }
	///<summary>HasAnyButtons</summary>
	public bool HasAnyButtons() { return default; }
	///<summary>GetButtonCount</summary>
	public int GetButtonCount() { return default; }
	///<summary>If true, the group will force that a button be selected at all times</summary>
	public bool bSelectionRequired;
	///<summary>OnSelectionStateChangedBase</summary>
	public virtual void OnSelectionStateChangedBase(UCommonButtonBase BaseButton,bool bIsSelected) {}
	///<summary>OnHandleButtonBaseClicked</summary>
	public virtual void OnHandleButtonBaseClicked(UCommonButtonBase BaseButton) {}
	///<summary>OnHandleButtonBaseDoubleClicked</summary>
	public virtual void OnHandleButtonBaseDoubleClicked(UCommonButtonBase BaseButton) {}
	///<summary>OnButtonBaseHovered</summary>
	public virtual void OnButtonBaseHovered(UCommonButtonBase BaseButton) {}
	///<summary>OnButtonBaseUnhovered</summary>
	public virtual void OnButtonBaseUnhovered(UCommonButtonBase BaseButton) {}
}
