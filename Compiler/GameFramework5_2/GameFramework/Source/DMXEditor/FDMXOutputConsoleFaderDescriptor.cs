namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXEditorSettings.h")]
public partial struct FDMXOutputConsoleFaderDescriptor {
	public string FaderName;
	public byte Value;
	public byte MaxValue;
	public byte MinValue;
	public int UniversID;
	public int StartingAddress;
	public int EndingAddress;
	public FName ProtocolName;
}
