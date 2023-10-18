namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Source filter implementation used to replace filter instance who&#39;s UClass is not loaded and or does not exist, primarily used by Filter Preset loading</summary>
[CppInclude("EmptySourceFilter.h")]
public partial class UEmptySourceFilter : UDataSourceFilter {
	public static UClass StaticClass() {return default;}
	///<summary>MissingClassName</summary>
	public string MissingClassName;
}
