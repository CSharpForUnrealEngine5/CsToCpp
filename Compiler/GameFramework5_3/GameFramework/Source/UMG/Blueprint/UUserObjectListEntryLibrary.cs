namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Static library to supply &quot;for free&quot; functionality to widgets that implement IUserListEntry</summary>
[CppInclude("Blueprint/IUserObjectListEntry.h")]
public partial class UUserObjectListEntryLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the item in the owning list view that this entry is currently assigned to represent.</summary>
	public static UObject GetListItemObject(object /*UserObjectListEntry*/ UserObjectListEntry) { return default; }
}
