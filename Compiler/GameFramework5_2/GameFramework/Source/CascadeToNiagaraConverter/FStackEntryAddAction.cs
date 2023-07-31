#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
