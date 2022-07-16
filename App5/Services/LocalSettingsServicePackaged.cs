using App5.Contracts.Services;
using App5.Core.Helpers;

using Windows.Storage;

namespace App5.Services;

public class LocalSettingsServicePackaged : ILocalSettingsService
{
    public async Task<T?> ReadSettingAsync<T>(string key)
    {
        if (ApplicationData.Current.LocalSettings.Values.TryGetValue(key, out var obj))
        {
            return await Json.ToObjectAsync<T>((string)obj);
        }

        return default;
    }

    public async Task SaveSettingAsync<T>(string key, T value)
    {
        ApplicationData.Current.LocalSettings.Values[key] = await Json.StringifyAsync(value);
    }
}
