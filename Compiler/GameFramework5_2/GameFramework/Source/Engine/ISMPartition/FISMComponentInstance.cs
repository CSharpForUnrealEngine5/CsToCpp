namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents one component instance with a mapping back to the Client instance. The should be a 1 to 1 relationship between those and the actual Component instances. (equal count)</summary>
[CppInclude("ISMPartition/ISMComponentData.h")]
public partial struct FISMComponentInstance {
	public int ClientIndex;
	public int InstanceIndex;
	public int InstanceSubIndex;
}
