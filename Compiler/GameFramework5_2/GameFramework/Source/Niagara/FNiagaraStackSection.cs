#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines data for sections visible in the stack view.</summary>
[CppInclude("NiagaraStackSection.h")]
public partial struct FNiagaraStackSection {
	public string SectionIdentifier;
	public string SectionDisplayName;
	public TArray<string> Categories;
	public bool bEnabled;
}
