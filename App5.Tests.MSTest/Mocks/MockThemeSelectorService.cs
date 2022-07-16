using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App5.Contracts.Services;
using Microsoft.UI.Xaml;

namespace App5.Tests.MSTest.Mocks;
internal class MockThemeSelectorService : IThemeSelectorService
{
    public ElementTheme Theme => ElementTheme.Default;

    public Task InitializeAsync() => Task.CompletedTask;
    public Task SetRequestedThemeAsync() => Task.CompletedTask;
    public Task SetThemeAsync(ElementTheme theme) => Task.CompletedTask;
}
