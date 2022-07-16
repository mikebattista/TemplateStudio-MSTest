using App5.Tests.MSTest.Mocks;
using App5.ViewModels;
using CommunityToolkit.WinUI;
using Microsoft.Windows.ApplicationModel.Resources;

namespace App5.Tests.MSTest;

[TestClass]
public class SettingsViewModelTests
{
    private readonly SettingsViewModel _viewModel;

    public SettingsViewModelTests()
    {
        _viewModel = new SettingsViewModel(new MockThemeSelectorService());
    }

    [TestMethod]
    public void VerifyAppDisplayNameWithAPI()
    {
        var resourceLoader = new ResourceLoader();
        Assert.AreEqual("App1", resourceLoader.GetString("AppDisplayName"));
    }

    [TestMethod]
    public void VerifyAppDisplayNameWithExtensionMethod()
    {
        Assert.AreEqual("App1", "AppDisplayName".GetLocalized());
    }

    [TestMethod]
    public void VerifyVersionDescription()
    {
        Assert.AreEqual("App1 - 1.0.0.0", _viewModel.VersionDescription);
    }
}
