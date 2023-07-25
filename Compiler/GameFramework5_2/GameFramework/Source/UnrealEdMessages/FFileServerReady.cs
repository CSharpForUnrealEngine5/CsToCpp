#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FileServerMessages.h")]
///<summary>Implements a message that is published by file servers when they're ready to accept connections.</summary>
public partial struct FFileServerReady {
// FileServerReady
	public TArray<string> AddressList;
	public FGuid InstanceId;
}
