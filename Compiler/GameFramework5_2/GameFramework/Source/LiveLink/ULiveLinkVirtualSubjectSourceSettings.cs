#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>VirtualSubjectSource Settings to be able to differentiate from live sources and keep a name associated to the source</summary>
[CppInclude("LiveLinkVirtualSource.h")]
public partial class ULiveLinkVirtualSubjectSourceSettings : ULiveLinkSourceSettings {
	public static UClass StaticClass() {return default;}
	///<summary>SourceName</summary>
	public string SourceName;
}
