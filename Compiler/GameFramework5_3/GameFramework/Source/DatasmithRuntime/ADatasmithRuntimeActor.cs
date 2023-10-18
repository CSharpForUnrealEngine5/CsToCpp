namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithRuntime.h")]
public partial class ADatasmithRuntimeActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>End ISceneChangeListener interface</summary>
	public bool IsConnected() { return default; }
	///<summary>GetDestinationName</summary>
	public string GetDestinationName() { return default; }
	///<summary>GetSourceName</summary>
	public string GetSourceName() { return default; }
	///<summary>OpenConnectionWithIndex</summary>
	public bool OpenConnectionWithIndex(int SourceIndex) { return default; }
	///<summary>CloseConnection</summary>
	public void CloseConnection() {}
	///<summary>GetSourceIndex</summary>
	public int GetSourceIndex() { return default; }
	///<summary>Progress</summary>
	public float Progress;
	///<summary>bBuilding</summary>
	public bool bBuilding;
	///<summary>LoadedScene</summary>
	public string LoadedScene;
	///<summary>ImportOptions</summary>
	public FDatasmithRuntimeImportOptions ImportOptions;
	///<summary>ExternalFile</summary>
	public string ExternalFile;
	///<summary>IsReceiving</summary>
	public bool IsReceiving() { return default; }
	///<summary>Reset</summary>
	public void Reset() {}
	///<summary>LoadFile</summary>
	public bool LoadFile(string FilePath) { return default; }
}
