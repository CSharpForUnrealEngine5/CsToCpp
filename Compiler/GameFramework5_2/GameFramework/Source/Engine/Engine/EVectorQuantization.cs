namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ReplicatedState.h")]
///<summary>Describes rules for network replicating a vector efficiently</summary>
public enum EVectorQuantization {
	RoundWholeNumber=0,
	RoundOneDecimal=1,
	RoundTwoDecimals=2,
}
