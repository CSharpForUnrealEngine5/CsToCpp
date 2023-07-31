#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Profiler Service data.</summary>
[CppInclude("ProfilerServiceMessages.h")]
public partial struct FProfilerServiceData2 {
	public FGuid InstanceId;
	public long Frame;
	public int CompressedSize;
	public int UncompressedSize;
	public string HexData;
}
