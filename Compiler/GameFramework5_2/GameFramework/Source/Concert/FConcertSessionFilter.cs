namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds filter rules used when migrating session data</summary>
[CppInclude("ConcertMessageData.h")]
public partial struct FConcertSessionFilter {
	public long ActivityIdLowerBound;
	public long ActivityIdUpperBound;
	public TArray<long> ActivityIdsToExclude;
	public TArray<long> ActivityIdsToInclude;
	public bool bOnlyLiveData;
	public bool bMetaDataOnly;
	public bool bIncludeIgnoredActivities;
}
