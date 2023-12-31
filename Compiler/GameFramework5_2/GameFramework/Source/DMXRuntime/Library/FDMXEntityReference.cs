namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents an Entity from a DMX Library.</summary>
[CppInclude("Library/DMXEntityReference.h")]
public partial struct FDMXEntityReference {
	public UDMXLibrary DMXLibrary;
	public bool bDisplayLibraryPicker;
	public UClass EntityType;
	public FGuid EntityId;
}
