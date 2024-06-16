using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeModManager.Languages
{
    internal class Russian : Language
    {
        public Dictionary<String, String> GetLanguage()
        {
            var language = new Dictionary<String, String>()
            {
                {"enableMods", "Включить моды"},
                {"disableMods", "Отключить моды"},
                {"modsEnabled", "Моды включены!"},
                {"modsDisabled", "Моды отключены!"},
                {"uncategorized", "Без категории"},
                {"gettingLatestVersionInfo", "Получаем новейшую информацию..."},
                {"releaseInfoUpdated", "Информация обновлена!"},
                {"notGorillaTag", "Это не запускаемый файл Gorilla Tag! Попробуйте снова!"},
                {"error", "Ошибка!"},
                {"uninstallAll", "Вы пытаетесь удалить все свои моды (включая все сохранения модов). Это нельзя отменить!\n\nВы уверены?"},
                {"confirmDelete", "Подтвердите Удаление"},
                {"deletingMods", "Удаляем ваши моды..."},
                {"somethingWentWrong", "Что-то пошло не так!"},
                {"failedToUninstallMods", "Не удалось удалить моды!"},
                {"modsUninstalled", "Все моды удалены успешно!"},
                {"backupFailed", "Не удалось сделать резервное копирование модов!"},
                {"backupSuccess", "Успешно сделана резервная копия модов!"},
                {"backupProcess", "Создаём резервную копию модов..."},
                {"invalidFile", "Неправильный файл!"},
                {"restoreFail", "Моды восстановвлены!"},
                {"restoreSuccess", "Моды восстановвлены!"},
                {"restoreProcess", "Восстанавливаем моды..."},
                {"configFolder", "Папка конфига"},
                {"modsFolder", "Папка модов"},
                {"gameFolder", "Папка игры"},
                {"viewModInfo", "Страница мода"},
                {"installUpdate", "Установить / Обновить"},
                {"uninstallAllMods", "Удалить моды"},
                {"backupMods", "Создать резервную копию"},
                {"restoreMods", "Восстановить моды"},
                {"selectLanguage", "Выбрать язык"},
                {"status", "Статус"},
                {"gorillaTagFolderPath", "Папка Gorilla Tag:"},
            };

            return language;
        }

        //public readonly String enableMods = "Включить моды";
        //public readonly String disableMods = "Отключить моды";
        //public readonly String modsEnabled = "Моды включены!";
        //public readonly String modsDisabled = "Моды отключены!";
        //public readonly String uncategorized = "Без категории";
        //public readonly String gettingLatestVersionInfo = "Получаем новейшую информацию..."; // Плохо перевёл
        //public readonly String releaseInfoUpdated = "Информация обновлена!";
        //public readonly String notGorillaTag = "Это не запускаемый файл Gorilla Tag! Попробуйте снова!";
        //public readonly String error = "Ошибка!";
        //public readonly String uninstallAll = "Вы пытаетесь удалить все свои моды (включая все сохранения модов). Это нельзя отменить!\n\nВы уверены?";
        //public readonly String confirmDelete = "Подтвердите Удаление";
        //public readonly String deletingMods = "Удаляем ваши моды...";
        //public readonly String somethingWentWrong = "Что-то пошло не так!";
        //public readonly String failedToUninstallMods = "Не удалось удалить моды!";
        //public readonly String modsUninstalled = "Все моды удалены успешно!";
        //public readonly String backupFailed = "Не удалось сделать резервное копирование модов!";
        //public readonly String backupSuccess = "Успешно сделана резервная копия модов!";
        //public readonly String backupProcess = "Создаём резервную копию модов...";
        //public readonly String invalidFile = "Неправильный файл!";
        //public readonly String restoreFail = "Не удалось восстановить моды!";
        //public readonly String restoreSuccess = "Моды восстановвлены!";
        //public readonly String restoreProcess = "Восстанавливаем моды...";
        //public readonly String configFolder = "Папка конфига";
        //public readonly String modsFolder = "Папка модов";
        //public readonly String gameFolder = "Папка игры";
        //public readonly String viewModInfo = "Страница мода";
        //public readonly String installUpdate = "Установить / Обновить";
        //public readonly String uninstallAllMods = "Удалить моды";
        //public readonly String backupMods = "Создать резервную копию";
        //public readonly String restoreMods = "Восстановить моды";
        //public readonly String selectLanguage = "Select language";
        //public readonly String status = "Статус";
        //public readonly String gorillaTagFolderPath = "Папка Gorilla Tag:";
    }
}
