namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for filter specific configuration.</summary>
[CppInclude("Iris/ReplicationSystem/Filtering/NetObjectFilter.h")]
public partial class UNetObjectFilterConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Can be used to modify when the filter is executed</summary>
	public ENetFilterType FilterType;
}
