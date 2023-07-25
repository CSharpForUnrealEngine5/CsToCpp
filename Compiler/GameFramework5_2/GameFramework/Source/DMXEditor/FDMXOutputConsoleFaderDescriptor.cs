#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXEditorSettings.h")]
public partial struct FDMXOutputConsoleFaderDescriptor {
// DMXOutputConsoleFaderDescriptor
	public string FaderName;
	public byte Value;
	public byte MaxValue;
	public byte MinValue;
	public int UniversID;
	public int StartingAddress;
	public int EndingAddress;
	public string ProtocolName;
}
