namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcCalibrationData.h")]
public partial class UMrcCalibrationSaveGame : UMrcCalibrationData {
	public static UClass StaticClass() {return default;}
	///<summary>Metadata about the save file</summary>
	public string SaveSlotName;
	///<summary>UserIndex</summary>
	public int UserIndex;
	///<summary>ConfigurationSaveVersion</summary>
	public int ConfigurationSaveVersion;
}
