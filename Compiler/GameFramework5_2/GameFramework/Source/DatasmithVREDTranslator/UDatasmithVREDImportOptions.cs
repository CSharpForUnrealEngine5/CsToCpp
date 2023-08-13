namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithVREDImportOptions.h")]
public partial class UDatasmithVREDImportOptions : UDatasmithFBXImportOptions {
	public static UClass StaticClass() {return default;}
	///<summary>Uses the *.mats file saved alongside the exported FBX for a more accurate material reproduction</summary>
	public bool bImportMats;
	///<summary>Path to the *.mats file. By default it will search for a *.mats file in the same folder as the FBX file, with the same base filename as it</summary>
	public FFilePath MatsPath;
	///<summary>Uses the *.var file saved alongside the exported FBX</summary>
	public bool bImportVar;
	///<summary>Removes empty variants, variant sets and invalid options. All discarded items will be logged to console.</summary>
	public bool bCleanVar;
	///<summary>Path to the *.var file. By default it will search for a *.var file in the same folder as the FBX file, with the same base filename as it</summary>
	public FFilePath VarPath;
	///<summary>Uses the *.lights file saved alongside the exported FBX to import extra information about lights not saved in the FBX file</summary>
	public bool bImportLightInfo;
	///<summary>Path to the *.lights file. By default it will search for a *.light file in the same folder as the FBX file, with the same base filename as it</summary>
	public FFilePath LightInfoPath;
	///<summary>Uses the *.clips file saved alongside the exported FBX to import information about animation clips and blocks, mirroring VRED&#39;s animation system</summary>
	public bool bImportClipInfo;
	///<summary>Path to the *.clips file. By default it will search for a *.clips file in the same folder as the FBX file, with the same base filename as it</summary>
	public FFilePath ClipInfoPath;
}
