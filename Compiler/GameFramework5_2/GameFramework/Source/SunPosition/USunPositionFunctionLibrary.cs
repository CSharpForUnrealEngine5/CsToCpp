namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SunPosition.h")]
public partial class USunPositionFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get the sun&#39;s position data based on position, date and time</summary>
	public static void GetSunPosition(float Latitude,float Longitude,float TimeZone,bool bIsDaylightSavingTime,int Year,int Month,int Day,int Hours,int Minutes,int Seconds,FSunPositionData SunPositionData) {}
}
