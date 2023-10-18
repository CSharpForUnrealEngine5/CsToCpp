namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper struct that stores a connection between two sockets.</summary>
[CppInclude("NiagaraNodeConvert.h")]
public partial struct FNiagaraConvertConnection {
	public FGuid SourcePinId;
	public TArray<FName> SourcePath;
	public FGuid DestinationPinId;
	public TArray<FName> DestinationPath;
	public FGuid SourcePropertyId;
	public FGuid DestinationPropertyId;
}
