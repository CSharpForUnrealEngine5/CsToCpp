namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor only folder data for emitters in a system.</summary>
[CppInclude("NiagaraSystemEditorData.h")]
public partial class UNiagaraSystemEditorFolder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FolderName</summary>
	public string FolderName;
	///<summary>ChildFolders</summary>
	public TArray<UNiagaraSystemEditorFolder> ChildFolders;
	///<summary>ChildEmitterHandleIds</summary>
	public TArray<FGuid> ChildEmitterHandleIds;
}
