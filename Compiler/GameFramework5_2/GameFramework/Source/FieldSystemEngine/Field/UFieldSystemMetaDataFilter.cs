#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter the particles on which the field will be applied</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UFieldSystemMetaDataFilter : UFieldSystemMetaData {
	///<summary>Set the particles filter type</summary>
	public  UFieldSystemMetaDataFilter SetMetaDataFilterType(EFieldFilterType FilterType,EFieldObjectType ObjectType,EFieldPositionType PositionType) { return default; }
	///<summary>Filter state type used to select the particles on which the field will be applied</summary>
	public EFieldFilterType FilterType;
	///<summary>Filter object type used to select the particles on which the field will be applied</summary>
	public EFieldObjectType ObjectType;
	///<summary>Specify which position type will be used for the field evaluation</summary>
	public EFieldPositionType PositionType;
}
