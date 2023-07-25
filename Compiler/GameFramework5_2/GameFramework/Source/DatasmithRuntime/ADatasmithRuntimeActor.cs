#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithRuntime.h")]
public partial class ADatasmithRuntimeActor : AActor {
// DatasmithRuntimeActor
	public bool IsConnected() { return default; }
	public string GetDestinationName() { return default; }
	public string GetSourceName() { return default; }
	public bool OpenConnectionWithIndex(int SourceIndex) { return default; }
	public void CloseConnection() {}
	public int GetSourceIndex() { return default; }
	public float Progress;
	public bool bBuilding;
	public string LoadedScene;
	public FDatasmithRuntimeImportOptions ImportOptions;
	public string ExternalFile;
	public bool IsReceiving() { return default; }
	public void Reset() {}
	public bool LoadFile(string FilePath) { return default; }
}
