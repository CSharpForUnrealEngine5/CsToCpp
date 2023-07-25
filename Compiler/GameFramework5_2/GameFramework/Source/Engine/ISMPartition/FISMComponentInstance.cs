#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ISMPartition/ISMComponentData.h")]
///<summary>Represents one component instance with a mapping back to the Client instance. The should be a 1 to 1 relationship between those and the actual Component instances. (equal count)</summary>
public partial struct FISMComponentInstance {
// ISMComponentInstance
	public int ClientIndex;
	public int InstanceIndex;
	public int InstanceSubIndex;
}
