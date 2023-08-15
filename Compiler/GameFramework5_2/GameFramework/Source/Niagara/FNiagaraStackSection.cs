namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines data for sections visible in the stack view.</summary>
[CppInclude("NiagaraStackSection.h")]
public partial struct FNiagaraStackSection {
	public FName SectionIdentifier;
	public FText SectionDisplayName;
	public TArray<FText> Categories;
	public bool bEnabled;
}
