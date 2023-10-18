namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Control the set of particles on which the field will be applied</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UFieldSystemMetaDataProcessingResolution : UFieldSystemMetaData {
	public static UClass StaticClass() {return default;}
	///<summary>Set the processing resolution type</summary>
	public UFieldSystemMetaDataProcessingResolution SetMetaDataaProcessingResolutionType(EFieldResolutionType ResolutionType) { return default; }
	///<summary>Precessing resolution type used to select the particles on which the field will be applied</summary>
	public EFieldResolutionType ResolutionType;
}
