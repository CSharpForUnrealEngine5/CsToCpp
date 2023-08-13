namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneDMXLibrarySection.h")]
public partial struct FDMXFixturePatchChannel {
	public UDMXLibrary DMXLibrary;
	public FDMXEntityFixturePatchRef Reference;
	public TArray<FDMXFixtureFunctionChannel> FunctionChannels;
	public int ActiveMode;
}
