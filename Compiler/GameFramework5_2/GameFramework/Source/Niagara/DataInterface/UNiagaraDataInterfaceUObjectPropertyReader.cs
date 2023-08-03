#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data interface to read properties from UObjects.</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceUObjectPropertyReader.h")]
public partial class UNiagaraDataInterfaceUObjectPropertyReader : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>User parameter Object binding to read properties from.</summary>
	public FNiagaraUserParameterBinding UObjectParameterBinding;
	///<summary>PropertyRemap</summary>
	public TArray<FNiagaraUObjectPropertyReaderRemap> PropertyRemap;
	///<summary>Optional source actor to use, if the user parameter binding is valid this will be ignored.</summary>
	public TSoftObjectPtr<AActor> SourceActor;
	///<summary>When an actor is bound as the object we will also search for a component of this type to bind properties to.</summary>
	public UClass SourceActorComponentClass;
	///<summary>Remaps a property reader, where the</summary>
	public static void SetUObjectReaderPropertyRemap(UNiagaraComponent NiagaraComponent,string UserParameterName,string GraphName,string RemapName) {}
}
