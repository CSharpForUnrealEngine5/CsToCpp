namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor only UI data for emitters.</summary>
[CppInclude("NiagaraStackEditorData.h")]
public partial class UNiagaraStackEditorData : UNiagaraEditorDataBase {
	public static UClass StaticClass() {return default;}
	///<summary>bHideDisabledModules</summary>
	public bool bHideDisabledModules;
	///<summary>StackEntryKeyToExpandedMap</summary>
	public TMap<string,bool> StackEntryKeyToExpandedMap;
	///<summary>StackEntryKeyToExpandedOverviewMap</summary>
	public TMap<string,bool> StackEntryKeyToExpandedOverviewMap;
	///<summary>StackEntryKeyToDisplayName</summary>
	public TMap<string,FText> StackEntryKeyToDisplayName;
	///<summary>DismissedStackIssueIds</summary>
	public TArray<string> DismissedStackIssueIds;
}
