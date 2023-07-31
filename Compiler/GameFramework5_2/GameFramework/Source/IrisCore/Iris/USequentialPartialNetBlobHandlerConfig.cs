#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/NetBlob/SequentialPartialNetBlobHandler.h")]
public partial class USequentialPartialNetBlobHandlerConfig : UObject {
	///<summary>How many bits a PartialNetBlob payload can hold at most. Cannot exceed 65535, but anything near the max packet size is discouraged as it is unlikely to fit. Keep it a power of two.</summary>
	public uint MaxPartBitCount;
	///<summary>How many parts a NetBlob can be split into at most. If more parts are required the splitting will fail. Cannot exceed 65535.</summary>
	public uint MaxPartCount;
}
