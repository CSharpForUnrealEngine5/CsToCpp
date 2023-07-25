#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackEditorData.h")]
///<summary>Editor only UI data for emitters.</summary>
public partial class UNiagaraStackEditorData : UNiagaraEditorDataBase {
// NiagaraStackEditorData
	public bool bHideDisabledModules;
	public TMap<string,bool> StackEntryKeyToExpandedMap;
	public TMap<string,bool> StackEntryKeyToExpandedOverviewMap;
	public TMap<string,string> StackEntryKeyToDisplayName;
	public TArray<string> DismissedStackIssueIds;
}
