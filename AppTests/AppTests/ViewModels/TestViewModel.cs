#nullable enable

using CommunityToolkit.Mvvm.ComponentModel;

namespace AppTests.ViewModels;

public sealed partial class TestViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _apiKey;
}
