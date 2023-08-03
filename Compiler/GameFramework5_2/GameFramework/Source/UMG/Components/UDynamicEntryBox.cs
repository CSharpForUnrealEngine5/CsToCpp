#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A special box panel that auto-generates its entries at both design-time and runtime.</summary>
[CppInclude("Components/DynamicEntryBox.h")]
public partial class UDynamicEntryBox : UDynamicEntryBoxBase {
	public static UClass StaticClass() {return default;}
	///<summary>Clear out the box entries, optionally deleting the underlying Slate widgets entirely as well.</summary>
	public  void Reset(bool bDeleteWidgets/*=false*/) {}
	///<summary>RemoveEntry</summary>
	public  void RemoveEntry(UUserWidget EntryWidget) {}
	///<summary>NumDesignerPreviewEntries</summary>
	public int NumDesignerPreviewEntries;
	///<summary>Creates and establishes a new dynamic entry in the box</summary>
	public  UUserWidget BP_CreateEntry() { return default; }
	///<summary>Creates and establishes a new dynamic entry in the box using the specified class instead of the default.</summary>
	public  UUserWidget BP_CreateEntryOfClass(UClass EntryClass) { return default; }
	///<summary>The class of widget to create entries of.</summary>
	public UClass EntryWidgetClass;
}
