namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEditorSettings.h")]
public partial struct FNiagaraNamespaceMetadata {
	public TArray<string> Namespaces;
	public string RequiredNamespaceModifier;
	public FText DisplayName;
	public FText DisplayNameLong;
	public FText Description;
	public FLinearColor BackgroundColor;
	public string ForegroundStyle;
	public int SortId;
	public TArray<string> OptionalNamespaceModifiers;
	public TArray<ENiagaraNamespaceMetadataOptions> Options;
	public FGuid Guid;
}
