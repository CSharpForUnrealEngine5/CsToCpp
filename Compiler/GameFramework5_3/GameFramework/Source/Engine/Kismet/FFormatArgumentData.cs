namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to pass argument/value pairs into FText::Format.</summary>
[CppInclude("Kismet/KismetTextLibrary.h")]
public partial struct FFormatArgumentData {
	public string ArgumentName;
	public EFormatArgumentType ArgumentValueType;
	public FText ArgumentValue;
	public long ArgumentValueInt;
	public float ArgumentValueFloat;
	public double ArgumentValueDouble;
	public ETextGender ArgumentValueGender;
}
