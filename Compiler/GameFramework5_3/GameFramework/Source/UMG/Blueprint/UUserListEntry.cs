namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/IUserListEntry.h")]
public partial class UUserListEntry : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Called when the selection state of the item represented by this entry changes.</summary>
	public void BP_OnItemSelectionChanged(bool bIsSelected) {}
	///<summary>Called when the expansion state of the item represented by this entry changes. Tree view entries only.</summary>
	public void BP_OnItemExpansionChanged(bool bIsExpanded) {}
	///<summary>Called when this entry is released from the owning table and no longer represents any list item</summary>
	public void BP_OnEntryReleased() {}
}
