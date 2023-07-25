#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/DMXLibraryFromMVRImportOptions.h")]
///<summary>Import Options when importing an MVR File as DMX Library.</summary>
public partial class UDMXLibraryFromMVRImportOptions : UObject {
// DMXLibraryFromMVRImportOptions
	public bool bIsReimport;
	public bool bCreateNewDMXLibrary;
	public UDMXLibrary ImportIntoDMXLibrary;
	public bool bReimportExisitingGDTFs;
	public bool bUpdateInputPort;
	public FDMXInputPortReference InputPortToUpdate;
	public bool bUpdateOutputPort;
	public FDMXOutputPortReference OutputPortToUpdate;
}
