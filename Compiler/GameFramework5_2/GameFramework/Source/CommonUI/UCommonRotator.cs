#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A button that can rotate between given text labels.</summary>
[CppInclude("CommonRotator.h")]
public partial class UCommonRotator : UCommonButtonBase {
	public static UClass StaticClass() {return default;}
	///<summary>Set the array of texts available</summary>
	public  void PopulateTextLabels(TArray<string> Labels) {}
	///<summary>Gets the current text value of the slider.</summary>
	public  string GetSelectedText() { return default; }
	///<summary>Sets the current value of the slider.</summary>
	public  void SetSelectedItem(int InValue) {}
	///<summary>Gets the current selected index</summary>
	public  int GetSelectedIndex() { return default; }
	///<summary>Shift the current text left.</summary>
	public  void ShiftTextLeft() {}
	///<summary>Shift the current text right.</summary>
	public  void ShiftTextRight() {}
	///<summary>Called when the Selected state of this button changes</summary>
	public FOnRotated OnRotated;
	///<summary>BP_OnOptionsPopulated</summary>
	public  void BP_OnOptionsPopulated(int Count) {}
	///<summary>BP_OnOptionSelected</summary>
	public  void BP_OnOptionSelected(int Index) {}
	///<summary>The displayed text</summary>
	public UCommonTextBlock MyText;
}
