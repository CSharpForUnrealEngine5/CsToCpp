namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/Filtering/NetObjectConnectionFilter.h")]
public partial class UNetObjectConnectionFilterConfig : UNetObjectFilterConfig {
	public static UClass StaticClass() {return default;}
	///<summary>The maximum amount of objects that may be added to the filter. It&#39;s not designed to handle massive amounts- static connection filtering via the ReplicationSystem API is preferred.</summary>
	public ushort MaxObjectCount;
}
