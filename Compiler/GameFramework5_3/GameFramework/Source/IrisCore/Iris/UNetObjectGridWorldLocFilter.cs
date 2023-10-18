namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter for replicated objects that have a WorldLocation reference (e.g. Actors).</summary>
[CppInclude("Iris/ReplicationSystem/Filtering/NetObjectGridFilter.h")]
public partial class UNetObjectGridWorldLocFilter : UNetObjectGridFilter {
	public static UClass StaticClass() {return default;}
}
