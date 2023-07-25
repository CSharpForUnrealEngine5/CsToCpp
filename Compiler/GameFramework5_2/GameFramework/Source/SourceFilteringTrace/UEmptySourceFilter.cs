#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EmptySourceFilter.h")]
///<summary>Source filter implementation used to replace filter instance who's UClass is not loaded and or does not exist, primarily used by Filter Preset loading</summary>
public partial class UEmptySourceFilter : UDataSourceFilter {
// EmptySourceFilter
	public string MissingClassName;
}
