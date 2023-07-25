#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Fetchers/DataprepBoolFetcherLibrary.h")]
///<summary>Filter objects based of their selected class.</summary>
public partial class UDataprepIsClassOfFetcher : UDataprepBoolFetcher {
// DataprepIsClassOfFetcher
	public UClass Class;
	public bool bShouldIncludeChildClass;
}
