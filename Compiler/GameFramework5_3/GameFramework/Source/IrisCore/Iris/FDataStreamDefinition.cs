namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/DataStream/DataStreamDefinitions.h")]
public partial struct FDataStreamDefinition {
	public FName DataStreamName;
	public FName ClassName;
	public UClass Class;
	public EDataStreamSendStatus DefaultSendStatus;
	public bool bAutoCreate;
}
