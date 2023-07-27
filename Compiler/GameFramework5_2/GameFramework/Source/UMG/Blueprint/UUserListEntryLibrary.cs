#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/IUserListEntry.h")]
///<summary>Static library to supply "for free" functionality to widgets that implement IUserListEntry</summary>
public partial class UUserListEntryLibrary : UBlueprintFunctionLibrary {
// UserListEntryLibrary
	public static bool IsListItemSelected(object /*UserListEntry*/ UserListEntry) { return default; }
	public static bool IsListItemExpanded(object /*UserListEntry*/ UserListEntry) { return default; }
	public static UListViewBase GetOwningListView(object /*UserListEntry*/ UserListEntry) { return default; }
}
