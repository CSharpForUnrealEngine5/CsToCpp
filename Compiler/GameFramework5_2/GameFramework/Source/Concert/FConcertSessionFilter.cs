#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessageData.h")]
///<summary>Holds filter rules used when migrating session data</summary>
public partial struct FConcertSessionFilter {
// ConcertSessionFilter
	public long ActivityIdLowerBound;
	public long ActivityIdUpperBound;
	public TArray<long> ActivityIdsToExclude;
	public TArray<long> ActivityIdsToInclude;
	public bool bOnlyLiveData;
	public bool bMetaDataOnly;
	public bool bIncludeIgnoredActivities;
}
