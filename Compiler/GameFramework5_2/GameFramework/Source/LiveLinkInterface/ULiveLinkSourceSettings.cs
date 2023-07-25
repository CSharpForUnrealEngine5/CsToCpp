#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkSourceSettings.h")]
///<summary>Base class for live link source settings (can be replaced by sources themselves)</summary>
public partial class ULiveLinkSourceSettings : UObject {
// LiveLinkSourceSettings
	public ELiveLinkSourceMode Mode;
	public FLiveLinkSourceBufferManagementSettings BufferSettings;
	public string ConnectionString;
	public UClass Factory;
	public TArray<FLiveLinkSourceDebugInfo> SourceDebugInfos_DEPRECATED;
}
