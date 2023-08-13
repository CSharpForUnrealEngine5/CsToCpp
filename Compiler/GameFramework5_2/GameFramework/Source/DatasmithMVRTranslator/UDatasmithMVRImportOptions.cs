namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithMVRImportOptions.h")]
public partial class UDatasmithMVRImportOptions : UDatasmithOptionsBase {
	public static UClass StaticClass() {return default;}
	///<summary>If set to true, datasmith elements that correspond to an entry in the MVR are replaced with GDTF Actors</summary>
	public bool bImportMVR;
}
