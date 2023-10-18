namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassCrowdServerRepresentationTrait.h")]
public partial class UMassCrowdServerRepresentationTrait : UMassEntityTraitBase {
	public static UClass StaticClass() {return default;}
	///<summary>Actor class of this agent when spawned on server</summary>
	public UClass TemplateActor;
	///<summary>Configuration parameters for the representation processor</summary>
	public FMassRepresentationParameters Params;
}
