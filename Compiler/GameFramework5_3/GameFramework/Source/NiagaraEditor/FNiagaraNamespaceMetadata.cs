namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEditorSettings.h")]
public partial struct FNiagaraNamespaceMetadata {
	public TArray<FName> Namespaces;
	public FName RequiredNamespaceModifier;
	public FText DisplayName;
	public FText DisplayNameLong;
	public FText Description;
	public FLinearColor BackgroundColor;
	public FName ForegroundStyle;
	public int SortId;
	public TArray<FName> OptionalNamespaceModifiers;
	public TArray<ENiagaraNamespaceMetadataOptions> Options;
	public FGuid Guid;
}
