#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassCrowdServerRepresentationTrait.h")]
public partial class UMassCrowdServerRepresentationTrait : UMassEntityTraitBase {
	///<summary>Actor class of this agent when spawned on server</summary>
	public UClass TemplateActor;
	///<summary>Configuration parameters for the representation processor</summary>
	public FMassRepresentationParameters Params;
}
