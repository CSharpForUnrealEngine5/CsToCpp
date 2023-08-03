#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Commandlet for processing UE packet captures, through Oodle&#39;s training API, for generating compressed state dictionaries.</summary>
[CppInclude("OodleNetworkTrainerCommandlet.h")]
public partial class UOodleNetworkTrainerCommandlet : UCommandlet {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not compression testing should be performed after dictionary generation (uses up some of the packets)</summary>
	public bool bCompressionTest;
	///<summary>Whether or not to write oodle version 5 dictionaries for back compat</summary>
	public bool bWriteV5Dictionaries;
	///<summary>Size of the hash table to use for the dictionary</summary>
	public int HashTableSize;
	///<summary>Size of the dictionary to be generated</summary>
	public int DictionarySize;
	///<summary>The number of random packet-selection trials to run, when generating the dictionary, to try and optimize the dictionary</summary>
	public int DictionaryTrials;
	///<summary>The randomness, in percent, of random packet-selection trials</summary>
	public int TrialRandomness;
	///<summary>The number of generations of random packet-selection trials</summary>
	public int TrialGenerations;
	///<summary>Whether or not random-trials have been disabled</summary>
	public bool bNoTrials;
}
