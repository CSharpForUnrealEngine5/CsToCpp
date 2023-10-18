namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is published by file servers when they&#39;re ready to accept connections.</summary>
[CppInclude("FileServerMessages.h")]
public partial struct FFileServerReady {
	public TArray<string> AddressList;
	public FGuid InstanceId;
}
