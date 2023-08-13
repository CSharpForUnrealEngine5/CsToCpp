namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityFixtureType.h")]
public partial struct FDMXFixtureMode {
	public string ModeName;
	public TArray<FDMXFixtureFunction> Functions;
	public bool bAutoChannelSpan;
	public int ChannelSpan;
	public bool bFixtureMatrixEnabled;
	public FDMXFixtureMatrix FixtureMatrixConfig;
}
