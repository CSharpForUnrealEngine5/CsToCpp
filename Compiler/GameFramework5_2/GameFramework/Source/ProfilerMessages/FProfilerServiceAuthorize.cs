#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Profiler Service authorization message.</summary>
[CppInclude("ProfilerServiceMessages.h")]
public partial struct FProfilerServiceAuthorize {
	public FGuid SessionId;
	public FGuid InstanceId;
}
