#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor only folder data for emitters in a system.</summary>
[CppInclude("NiagaraSystemEditorData.h")]
public partial class UNiagaraSystemEditorFolder : UObject {
	///<summary>FolderName</summary>
	public string FolderName;
	///<summary>ChildFolders</summary>
	public TArray<UNiagaraSystemEditorFolder> ChildFolders;
	///<summary>ChildEmitterHandleIds</summary>
	public TArray<FGuid> ChildEmitterHandleIds;
}
