namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFolder.h")]
public partial class UActorFolder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ParentFolderGuid</summary>
	public FGuid ParentFolderGuid;
	///<summary>FolderGuid</summary>
	public FGuid FolderGuid;
	///<summary>FolderLabel</summary>
	public string FolderLabel;
	///<summary>bFolderInitiallyExpanded</summary>
	public bool bFolderInitiallyExpanded;
	///<summary>bIsDeleted</summary>
	public bool bIsDeleted;
}
