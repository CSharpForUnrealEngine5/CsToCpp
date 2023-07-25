#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DynamicEntryBox.h")]
///<summary>A special box panel that auto-generates its entries at both design-time and runtime.</summary>
public partial class UDynamicEntryBox : UDynamicEntryBoxBase {
// DynamicEntryBox
	public void Reset(bool bDeleteWidgets/*=false*/) {}
	public void RemoveEntry(UObject EntryWidget) {}
	public int NumDesignerPreviewEntries;
	public UObject BP_CreateEntry() { return default; }
	public UObject BP_CreateEntryOfClass(UClass EntryClass) { return default; }
	public UClass EntryWidgetClass;
}
