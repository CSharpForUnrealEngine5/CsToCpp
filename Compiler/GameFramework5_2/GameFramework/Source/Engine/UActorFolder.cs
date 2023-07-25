#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFolder.h")]
public partial class UActorFolder : UObject {
// ActorFolder
	public FGuid ParentFolderGuid;
	public FGuid FolderGuid;
	public string FolderLabel;
	public bool bFolderInitiallyExpanded;
	public bool bIsDeleted;
}
