using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeModManager.Languages
{
    internal class English : Language
    {
        public Dictionary<String, String> GetLanguage()
        {
            var language = new Dictionary<String, String>()
            {
                {"enableMods", "Enable mods"},
                {"disableMods", "Disable mods"},
                {"modsEnabled", "Mods enabled!"},
                {"modsDisabled", "Mods disabled!"},
                {"uncategorized", "Uncategorized"},
                {"gettingLatestVersionInfo", "Getting latest version info..."},
                {"releaseInfoUpdated", "Release info updated!"},
                {"notGorillaTag", "That's not the Gorilla Tag exectuable! please try again!"},
                {"error", "Error!"},
                {"uninstallAll", "You are about to delete all your mods (including any saved data in your plugins). This cannot be undone!\n\nAre you sure you wish to continue?"},
                {"confirmDelete", "Confirm Delete"},
                {"deletingMods", "Uninstalling all mods..."},
                {"somethingWentWrong", "Something went wrong!"},
                {"failedToUninstallMods", "Failed to uninstall mods!"},
                {"modsUninstalled", "All mods uninstalled successfully!"},
                {"backupFailed", "Failed to back up mods"},
                {"backupSuccess", "Successfully backed up mods!"},
                {"backupProcess", "Backing up mods..."},
                {"invalidFile", "Invalid file!"},
                {"restoreFail", "Failed to restore mods!"},
                {"restoreSuccess", "Successfully restored mods!"},
                {"restoreProcess", "Restoring mods..."},
                {"configFolder", "Config folder"},
                {"modsFolder", "Mods folder"},
                {"gameFolder", "Game folder"},
                {"viewModInfo", "View Mod Info"},
                {"installUpdate", "Install / Update"},
                {"uninstallAllMods", "Uninstall All Mods"},
                {"backupMods", "Backup Mods"},
                {"restoreMods", "Restore Mods"},
                {"selectLanguage", "Select Language"},
                {"status", "Status"},
                {"gorillaTagFolderPath", "Gorilla Tag Folder Path:"},
            };

            return language;
        }
    }
}
