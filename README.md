# mauiAppearEventProblem

Shows that on a page the OnAppearing and OnDisappearing event on Windows is raised too often.
To reproduce build the application on windows.
After the windows appears, the counter is correct at 1 for appearing, 0 for disappering.
Now just add some other window on top of the application and get the application back to the foreground. Now the appearing is 2.

The link is for the xamaring documention due to the lack of maui documentation: https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.page.onappearing?view=xamarin-forms
The disappearing documentation has a interesting remark: The disappear is not triggered if the app is not visible due to an external app. But this is clearing not the case on windows with maui.
see https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.page.ondisappearing?view=xamarin-forms#remarks
