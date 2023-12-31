namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/IUserObjectListEntry.h")]
public partial class UUserObjectListEntry : UUserListEntry {
	public static UClass StaticClass() {return default;}
	///<summary>Called when this entry is assigned a new item object to represent by the owning list view</summary>
	public void OnListItemObjectSet(UObject ListItemObject) {}
}
