namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/NetBlob/PartialNetObjectAttachmentHandler.h")]
public partial class UPartialNetObjectAttachmentHandlerConfig : USequentialPartialNetBlobHandlerConfig {
	public static UClass StaticClass() {return default;}
	///<summary>How many bits a payload should have to recommend a split. Should be higher than MaxPartBitCount as splitting adds overhead.</summary>
	public uint BitCountSplitThreshold;
}
