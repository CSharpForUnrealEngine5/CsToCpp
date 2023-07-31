#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Control the set of particles on which the field will be applied</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UFieldSystemMetaDataProcessingResolution : UFieldSystemMetaData {
	///<summary>Set the processing resolution type</summary>
	public  UFieldSystemMetaDataProcessingResolution SetMetaDataaProcessingResolutionType(EFieldResolutionType ResolutionType) { return default; }
	///<summary>Precessing resolution type used to select the particles on which the field will be applied</summary>
	public EFieldResolutionType ResolutionType;
}
