#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/IUserListEntry.h")]
///<summary>Static library to supply "for free" functionality to widgets that implement IUserListEntry</summary>
public partial class UUserListEntryLibrary : UBlueprintFunctionLibrary {
// UserListEntryLibrary
	public bool IsListItemSelected(object /*UserListEntry*/ UserListEntry) { return default; }
	public bool IsListItemExpanded(object /*UserListEntry*/ UserListEntry) { return default; }
	public UObject GetOwningListView(object /*UserListEntry*/ UserListEntry) { return default; }
}
