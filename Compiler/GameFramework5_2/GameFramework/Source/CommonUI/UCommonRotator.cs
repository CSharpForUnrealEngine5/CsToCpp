#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonRotator.h")]
///<summary>A button that can rotate between given text labels.</summary>
public partial class UCommonRotator : UCommonButtonBase {
// CommonRotator
	public void PopulateTextLabels(TArray<string> Labels) {}
	public string GetSelectedText() { return default; }
	public void SetSelectedItem(int InValue) {}
	public int GetSelectedIndex() { return default; }
	public void ShiftTextLeft() {}
	public void ShiftTextRight() {}
	public FOnRotated OnRotated;
	public void BP_OnOptionsPopulated(int Count) {}
	public void BP_OnOptionSelected(int Index) {}
	public UCommonTextBlock MyText;
}
