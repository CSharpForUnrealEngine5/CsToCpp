#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for live link source settings (can be replaced by sources themselves)</summary>
[CppInclude("LiveLinkSourceSettings.h")]
public partial class ULiveLinkSourceSettings : UObject {
	///<summary>The the subject how to create the frame snapshot.</summary>
	public ELiveLinkSourceMode Mode;
	///<summary>How the frame buffers are managed.</summary>
	public FLiveLinkSourceBufferManagementSettings BufferSettings;
	///<summary>Connection information that is needed by the factory to recreate the source from a preset.</summary>
	public string ConnectionString;
	///<summary>Factory used to create the source.</summary>
	public UClass Factory;
	///<summary>SourceDebugInfos_DEPRECATED</summary>
	public TArray<FLiveLinkSourceDebugInfo> SourceDebugInfos_DEPRECATED;
}
