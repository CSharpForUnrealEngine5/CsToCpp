#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface for the strand base</summary>
[CppInclude("Niagara/NiagaraDataInterfaceHairStrands.h")]
public partial class UNiagaraDataInterfaceHairStrands : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Hair Strands Asset used to sample from when not overridden by a source actor from the scene. Also useful for previewing in the editor.</summary>
	public UGroomAsset DefaultSource;
	///<summary>The source actor from which to sample</summary>
	public AActor SourceActor;
}
