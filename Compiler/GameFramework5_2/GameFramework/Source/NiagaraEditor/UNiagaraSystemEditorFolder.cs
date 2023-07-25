#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSystemEditorData.h")]
///<summary>Editor only folder data for emitters in a system.</summary>
public partial class UNiagaraSystemEditorFolder : UObject {
// NiagaraSystemEditorFolder
	public string FolderName;
	public TArray<UNiagaraSystemEditorFolder> ChildFolders;
	public TArray<FGuid> ChildEmitterHandleIds;
}
