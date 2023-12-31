namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceGrid2DCollectionReader.h")]
public partial class UNiagaraDataInterfaceGrid2DCollectionReader : UNiagaraDataInterfaceGrid2DCollection {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the emitter to read from</summary>
	public string EmitterName;
	///<summary>Name of the Grid2DCollection Data Interface on the emitter</summary>
	public string DIName;
}
