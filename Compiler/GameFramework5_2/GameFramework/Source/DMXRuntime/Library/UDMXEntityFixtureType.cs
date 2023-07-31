#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to describe a type of Fixture. Fixture Patches can be created from Fixture Types (see UDMXEntityFixturePatch::ParentFixtureTypeTemplate).</summary>
[CppInclude("Library/DMXEntityFixtureType.h")]
public partial class UDMXEntityFixtureType : UDMXEntity {
	///<summary>Creates a new Fixture Type in the DMX Library</summary>
	public static UDMXEntityFixtureType CreateFixtureTypeInLibrary(FDMXEntityFixtureTypeConstructionParams ConstructionParams,string DesiredName/*=TEXT("")*/,bool bMarkDMXLibraryDirty/*=true*/) { return default; }
	///<summary>Removes a Fixture Type from a DMX Library</summary>
	public static void RemoveFixtureTypeFromLibrary(FDMXEntityFixtureTypeRef FixtureTypeRef) {}
	///<summary>SetModesFromDMXImport</summary>
	public  void SetModesFromDMXImport(UDMXImport DMXImportAsset) {}
	///<summary>The GDTF file from which the Fixture Type was setup</summary>
	public UDMXImport DMXImport;
	///<summary>The Category of the Fixture, useful for Filtering</summary>
	public FDMXFixtureCategory DMXCategory;
	///<summary>Modes</summary>
	public TArray<FDMXFixtureMode> Modes;
	///<summary>Modulators applied right before a patch of this type is received.</summary>
	public TArray<UDMXModulator> InputModulators;
	///<summary>bFixtureMatrixEnabled</summary>
	public bool bFixtureMatrixEnabled;
}
