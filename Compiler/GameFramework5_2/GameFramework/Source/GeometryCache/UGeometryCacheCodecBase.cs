#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interface for assets/objects that can own UserData *</summary>
[CppInclude("GeometryCacheCodecBase.h")]
public partial class UGeometryCacheCodecBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Frames at which the topology of the decoded frames changes sorted in increasing order</summary>
	public TArray<int> TopologyRanges;
}
