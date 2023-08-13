namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Profiler Service authorization message.</summary>
[CppInclude("ProfilerServiceMessages.h")]
public partial struct FProfilerServiceAuthorize {
	public FGuid SessionId;
	public FGuid InstanceId;
}
