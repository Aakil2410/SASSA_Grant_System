using SASSAGrantSystem.Debugging;

namespace SASSAGrantSystem
{
    public class SASSAGrantSystemConsts
    {
        public const string LocalizationSourceName = "SASSAGrantSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4d5306121b484483bb562e0720a57dd8";
    }
}
