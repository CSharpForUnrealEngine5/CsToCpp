#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Source filter implementation used to replace filter instance who&#39;s UClass is not loaded and or does not exist, primarily used by Filter Preset loading</summary>
[CppInclude("EmptySourceFilter.h")]
public partial class UEmptySourceFilter : UDataSourceFilter {
	///<summary>MissingClassName</summary>
	public string MissingClassName;
}
