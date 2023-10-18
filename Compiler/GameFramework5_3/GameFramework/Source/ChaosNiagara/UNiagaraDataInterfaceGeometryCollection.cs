namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface for the Collisions</summary>
[CppInclude("NiagaraDataInterfaceGeometryCollection.h")]
public partial class UNiagaraDataInterfaceGeometryCollection : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>GeometryCollectionActor</summary>
	public AGeometryCollectionActor GeometryCollectionActor;
}
