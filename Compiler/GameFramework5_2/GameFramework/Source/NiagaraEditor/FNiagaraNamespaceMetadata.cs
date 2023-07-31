#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEditorSettings.h")]
public partial struct FNiagaraNamespaceMetadata {
	public TArray<string> Namespaces;
	public string RequiredNamespaceModifier;
	public string DisplayName;
	public string DisplayNameLong;
	public string Description;
	public FLinearColor BackgroundColor;
	public string ForegroundStyle;
	public int SortId;
	public TArray<string> OptionalNamespaceModifiers;
	public TArray<ENiagaraNamespaceMetadataOptions> Options;
	public FGuid Guid;
}
