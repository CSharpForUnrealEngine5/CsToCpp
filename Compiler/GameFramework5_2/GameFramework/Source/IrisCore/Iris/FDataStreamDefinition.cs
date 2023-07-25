#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/DataStream/DataStreamDefinitions.h")]
public partial struct FDataStreamDefinition {
// DataStreamDefinition
	public string DataStreamName;
	public string ClassName;
	public UClass Class;
	public EDataStreamSendStatus DefaultSendStatus;
	public bool bAutoCreate;
}
