#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneDMXLibrarySection.h")]
public partial struct FDMXFixturePatchChannel {
// DMXFixturePatchChannel
	public UDMXLibrary DMXLibrary;
	public FDMXEntityFixturePatchRef Reference;
	public TArray<FDMXFixtureFunctionChannel> FunctionChannels;
	public int ActiveMode;
}
