#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Engine implementation of IDataSourceFilterSetInterface</summary>
[CppInclude("DataSourceFilterSet.h")]
public partial class UDataSourceFilterSet : UDataSourceFilter {
	public static UClass StaticClass() {return default;}
	///<summary>Contained Filter instance</summary>
	public TArray<UDataSourceFilter> Filters;
	///<summary>Current Filter set operation</summary>
	public EFilterSetMode Mode;
}
