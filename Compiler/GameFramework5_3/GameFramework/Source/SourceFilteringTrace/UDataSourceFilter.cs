namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataSourceFilter.h")]
public partial class UDataSourceFilter : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DoesActorPassFilter</summary>
	public bool DoesActorPassFilter(AActor InActor) { return default; }
	///<summary>Filter specific settings</summary>
	public FDataSourceFilterConfiguration Configuration;
}
