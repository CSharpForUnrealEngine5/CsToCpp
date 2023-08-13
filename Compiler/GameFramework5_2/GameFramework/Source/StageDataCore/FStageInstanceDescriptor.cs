namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds descriptive information about that data providers.</summary>
[CppInclude("StageMessages.h")]
public partial struct FStageInstanceDescriptor {
	public string MachineName;
	public uint ProcessId;
	public string RolesStringified;
	public string FriendlyName;
	public int SessionId;
}
