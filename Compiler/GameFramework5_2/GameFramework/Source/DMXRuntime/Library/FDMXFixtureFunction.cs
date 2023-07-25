#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityFixtureType.h")]
public partial struct FDMXFixtureFunction {
// DMXFixtureFunction
	public FDMXAttributeName Attribute;
	public string FunctionName;
	public string Description;
	public long DefaultValue;
	public int Channel;
	public int ChannelOffset_DEPRECATED;
	public EDMXFixtureSignalFormat DataType;
	public bool bUseLSBMode;
}
