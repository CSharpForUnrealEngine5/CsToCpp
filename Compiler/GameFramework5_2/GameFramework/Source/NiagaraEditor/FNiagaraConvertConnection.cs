#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper struct that stores a connection between two sockets.</summary>
[CppInclude("NiagaraNodeConvert.h")]
public partial struct FNiagaraConvertConnection {
	public FGuid SourcePinId;
	public TArray<string> SourcePath;
	public FGuid DestinationPinId;
	public TArray<string> DestinationPath;
	public FGuid SourcePropertyId;
	public FGuid DestinationPropertyId;
}
