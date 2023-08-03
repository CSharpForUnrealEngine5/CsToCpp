#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for imported Paper2D assets, such as sprite sheet textures.</summary>
[CppInclude("CryptoKeysSettings.h")]
public partial class UCryptoKeysSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The default encryption key used to protect pak files</summary>
	public string EncryptionKey;
	///<summary>Secondary encryption keys that can be selected for use on different assets. Games are required to make these keys available to the pak platform file at runtime in order to access the data they protect.</summary>
	public TArray<FCryptoEncryptionKey> SecondaryEncryptionKeys;
	///<summary>Encrypts all ini files in the pak. Gives security to the most common sources of mineable information, with minimal runtime IO cost</summary>
	public bool bEncryptPakIniFiles;
	///<summary>Encrypt the pak index, making it impossible to use unrealpak to manipulate the pak file without the encryption key</summary>
	public bool bEncryptPakIndex;
	///<summary>Encrypts the uasset file in cooked data. Less runtime IO cost, and protection to package header information, including most string data, but still leaves the bulk of the data unencrypted.</summary>
	public bool bEncryptUAssetFiles;
	///<summary>Encrypt all files in the pak file. Secure, but will cause some slowdown to runtime IO performance, and high entropy to packaged data which will be bad for patching</summary>
	public bool bEncryptAllAssetFiles;
	///<summary>The RSA key public exponent used for signing a pak file</summary>
	public string SigningPublicExponent;
	///<summary>The RSA key modulus used for signing a pak file</summary>
	public string SigningModulus;
	///<summary>The RSA key private exponent used for signing a pak file</summary>
	public string SigningPrivateExponent;
	///<summary>Enable signing of pak files, to prevent tampering of the data</summary>
	public bool bEnablePakSigning;
}
