namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
public partial struct FStackEntryAddAction {
	public EStackEntryAddActionMode Mode;
	public UNiagaraScriptConversionContext ScriptConversionContext;
	public UNiagaraClipboardFunction ClipboardFunction;
	public FStackEntryID StackEntryID;
	public string ModuleName;
}
