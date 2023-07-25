#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProfilerServiceMessages.h")]
///<summary>Profiler Service data.</summary>
public partial struct FProfilerServiceData2 {
// ProfilerServiceData2
	public FGuid InstanceId;
	public long Frame;
	public int CompressedSize;
	public int UncompressedSize;
	public string HexData;
}
