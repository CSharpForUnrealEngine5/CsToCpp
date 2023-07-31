#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to pass argument/value pairs into FText::Format.</summary>
[CppInclude("Kismet/KismetTextLibrary.h")]
public partial struct FFormatArgumentData {
	public string ArgumentName;
	public EFormatArgumentType ArgumentValueType;
	public string ArgumentValue;
	public long ArgumentValueInt;
	public float ArgumentValueFloat;
	public double ArgumentValueDouble;
	public ETextGender ArgumentValueGender;
}
