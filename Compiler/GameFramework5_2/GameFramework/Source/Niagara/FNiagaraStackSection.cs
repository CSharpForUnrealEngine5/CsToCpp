#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackSection.h")]
///<summary>Defines data for sections visible in the stack view.</summary>
public partial struct FNiagaraStackSection {
// NiagaraStackSection
	public string SectionIdentifier;
	public string SectionDisplayName;
	public TArray<string> Categories;
	public bool bEnabled;
}
