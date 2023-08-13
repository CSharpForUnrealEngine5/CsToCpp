namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithDeltaGenImportOptions.h")]
public partial class UDatasmithDeltaGenImportOptions : UDatasmithFBXImportOptions {
	public static UClass StaticClass() {return default;}
	///<summary>Don&#39;t keep nodes that marked invisible in FBX(an din the original scene), except switch variants</summary>
	public bool bRemoveInvisibleNodes;
	///<summary>Collapse nodes that have identity transform, have no mesh and not used in animation/variants/switches</summary>
	public bool bSimplifyNodeHierarchy;
	///<summary>import VAR files</summary>
	public bool bImportVar;
	///<summary>Path to the *.var file. By default it will search for a *.var file in the same folder as the FBX file, with the same base filename as it</summary>
	public FFilePath VarPath;
	///<summary>import POS files</summary>
	public bool bImportPos;
	///<summary>Path to the *.pos file. By default it will search for a *.pos file in the same folder as the FBX file, with the same base filename as it</summary>
	public FFilePath PosPath;
	///<summary>import TML files</summary>
	public bool bImportTml;
	///<summary>Path to the *.tml file. By default it will search for a *.tml file in the same folder as the FBX file, with the same base filename as it</summary>
	public FFilePath TmlPath;
	///<summary>How to handle shadow textures</summary>
	public EShadowTextureMode ShadowTextureMode;
}
