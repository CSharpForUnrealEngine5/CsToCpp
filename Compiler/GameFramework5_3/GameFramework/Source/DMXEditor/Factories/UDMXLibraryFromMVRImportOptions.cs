namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Import Options when importing an MVR File as DMX Library.</summary>
[CppInclude("Factories/DMXLibraryFromMVRImportOptions.h")]
public partial class UDMXLibraryFromMVRImportOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true, show options for Reimport</summary>
	public bool bIsReimport;
	///<summary>If checked, creates a new DMX Library</summary>
	public bool bCreateNewDMXLibrary;
	///<summary>Imports the MVR into the specified DMX Library. Note this will not merge, but clear Patches in the DMX Library.</summary>
	public UDMXLibrary ImportIntoDMXLibrary;
	///<summary>If checked, reimports GDTF that were previously imported</summary>
	public bool bReimportExisitingGDTFs;
	///<summary>If checked, updates the specified Input Port to span the Universe range of all Patches in the MVR file, or creates a new Input Port if none exist.</summary>
	public bool bUpdateInputPort;
	///<summary>The Input Port which is updated</summary>
	public FDMXInputPortReference InputPortToUpdate;
	///<summary>If checked, updates the specified Ouput Port to span the Universe range of all Patches in the MVR file, or creates a new Output Port if none exist.</summary>
	public bool bUpdateOutputPort;
	///<summary>The Output Port which is updated</summary>
	public FDMXOutputPortReference OutputPortToUpdate;
}
