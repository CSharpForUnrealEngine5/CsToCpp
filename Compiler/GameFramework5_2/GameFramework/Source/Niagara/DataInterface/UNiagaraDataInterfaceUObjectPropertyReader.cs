#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceUObjectPropertyReader.h")]
///<summary>Data interface to read properties from UObjects.</summary>
public partial class UNiagaraDataInterfaceUObjectPropertyReader : UNiagaraDataInterface {
// NiagaraDataInterfaceUObjectPropertyReader
	public FNiagaraUserParameterBinding UObjectParameterBinding;
	public TArray<FNiagaraUObjectPropertyReaderRemap> PropertyRemap;
	public TSoftObjectPtr<AActor> SourceActor;
	public UClass SourceActorComponentClass;
	public static void SetUObjectReaderPropertyRemap(UNiagaraComponent NiagaraComponent,string UserParameterName,string GraphName,string RemapName) {}
}
