namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransactionEvents.h")]
public enum ETransactionFilterResult {
	IncludeObject=0,
	ExcludeObject=1,
	ExcludeTransaction=2,
	UseDefault=3,
}
