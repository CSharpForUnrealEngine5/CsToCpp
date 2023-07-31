#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/NetBlob/PartialNetObjectAttachmentHandler.h")]
public partial class UPartialNetObjectAttachmentHandlerConfig : USequentialPartialNetBlobHandlerConfig {
	///<summary>How many bits a payload should have to recommend a split. Should be higher than MaxPartBitCount as splitting adds overhead.</summary>
	public uint BitCountSplitThreshold;
}
