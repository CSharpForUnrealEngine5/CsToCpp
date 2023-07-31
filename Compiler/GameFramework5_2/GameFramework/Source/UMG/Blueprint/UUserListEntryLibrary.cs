#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Static library to supply &quot;for free&quot; functionality to widgets that implement IUserListEntry</summary>
[CppInclude("Blueprint/IUserListEntry.h")]
public partial class UUserListEntryLibrary : UBlueprintFunctionLibrary {
	///<summary>Returns true if the item represented by this entry is currently selected in the owning list view.</summary>
	public static bool IsListItemSelected(object /*UserListEntry*/ UserListEntry) { return default; }
	///<summary>Returns true if the item represented by this entry is currently expanded and showing its children. Tree view entries only.</summary>
	public static bool IsListItemExpanded(object /*UserListEntry*/ UserListEntry) { return default; }
	///<summary>Returns the list view that contains this entry.</summary>
	public static UListViewBase GetOwningListView(object /*UserListEntry*/ UserListEntry) { return default; }
}
