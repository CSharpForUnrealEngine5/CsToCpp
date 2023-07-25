#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepIntegerFilter.h")]
public partial class UDataprepIntegerFilter : UDataprepFilter {
// DataprepIntegerFilter
	public UDataprepIntegerFetcher IntFetcher;
	public EDataprepIntegerMatchType IntegerMatchingCriteria;
	public int EqualValue;
	public int FromValue;
	public int ToValue;
}
