#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityReference.h")]
///<summary>Represents an Entity from a DMX Library.</summary>
public partial struct FDMXEntityReference {
// DMXEntityReference
	public UDMXLibrary DMXLibrary;
	public bool bDisplayLibraryPicker;
	public UClass EntityType;
	public FGuid EntityId;
}
