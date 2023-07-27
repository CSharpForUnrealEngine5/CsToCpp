#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetTextLibrary.h")]
///<summary>Used to pass argument/value pairs into FText::Format.</summary>
public partial struct FFormatArgumentData {
// FormatArgumentData
	public string ArgumentName;
	public EFormatArgumentType ArgumentValueType;
	public string ArgumentValue;
	public long ArgumentValueInt;
	public float ArgumentValueFloat;
	public double ArgumentValueDouble;
	public ETextGender ArgumentValueGender;
}
